using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Xml;
using System.Xml.Linq;
using System.Xml.Schema;
using Xbrl.Discovery.Entities;
using RGS.Mapping.Model;

namespace Xbrl.Discovery
{
    public class Dts : Entities.xml.Container
    {
        private int DocumentsInProcess = 0;
        public int UpdateDocumentsInProgress(int factor)
        {
            DocumentsInProcess += factor; 
            return DocumentsInProcess;
        }
        public static bool Cancelled { get; set; } = false;

        public Dictionary<string, Entities.xml.Document> Documents { get; } = new Dictionary<string, Entities.xml.Document>();
        public Dictionary<string, Entities.xs.Schema> Schemas { get; } = new Dictionary<string, Entities.xs.Schema>();
        public Dictionary<string, Entities.link.Linkbase> Linkbases { get; } = new Dictionary<string, Entities.link.Linkbase>();
        public Dictionary<string, Entities.xs.Element> GlobalXsElements { get; } = new Dictionary<string, Entities.xs.Element>();

        public bool SimpleReport { get; set; }

        public string Path { get; private set; } = string.Empty;
        public string TargetNamespaceEntrypoint { get; private set; } = string.Empty;

        public bool ReportValidationProblems { get; set; } = true;

        public Dictionary<XName, Type> BuiltInTypes { get; } = new Dictionary<XName, Type>();

        public Report Report { get; }

        public Dts() : base(default, default)
        {
            QName.ClearXmlNamespaceManager();
            Report = new Report();
            Cancelled = false;
            foreach (KeyValuePair<string, XNamespace> kvp in Namespaces.Items)
                QName.XmlNamespaceManager.AddNamespace(kvp.Key, kvp.Value.NamespaceName);
            foreach (Type type in GetType().Assembly.GetTypes())
            {
                if (type.IsSubclassOf(typeof(Entities.xml.Element)))
                {
                    //PropertyInfo piQname = type.GetProperty("QName");
                    //if (piQname != null && !type.ContainsGenericParameters)
                    //    xname = (RGS.Mapping.Model.QName)piQname.GetValue(null);
                    string prefix = type.Namespace.Split('.').Last();
                    if (Namespaces.Items.ContainsKey(prefix))
                    {
                        XNamespace xNamespace = Namespaces.Items[prefix];
                        string typeName = type.Name.Substring(0, 1).ToLower() + type.Name.Substring(1);
                        typeName = typeName.Split('`').First();
                        BuiltInTypes.TryAdd(xNamespace + typeName, type);
                    }
                }
            }
        }

        public void LoadDirectory(string directory)
        {
            Path = directory;
            try
            {
                OnDiscoverInfo("Started", directory);
                DirectoryInfo directoryInfo = new DirectoryInfo(directory);
                foreach (var file in directoryInfo.GetFiles("*.*", SearchOption.AllDirectories))
                {
                    DiscoverDocument(file.FullName);
                    if (Cancelled)
                        break;
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public void LoadFile(string filename, bool simpleReport)
        {
            SimpleReport = simpleReport;
            Path = filename;
            try
            {
                OnDiscoverInfo("Started", filename);
                DiscoverDocument(filename);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public void DiscoverDocument(string filename, string role = null)
        {
            try
            {
                filename = new Uri(filename).AbsoluteUri;
                if (!Cancelled && Documents.TryAdd(filename, value: null))
                {
                    UpdateDocumentsInProgress(+1);
                    OnDiscoverInfo("Discovering", filename);
                    Entities.xml.Document document = new Entities.xml.Document(this, filename);
                    Documents[filename] = document;
                    if (document.XObject.Root.Name == Entities.xs.Schema.QName)
                        DiscoverSchema(document);
                    else if (document.XObject.Root.Name == Entities.link.Linkbase.QName)
                        DiscoverLinkbase(document, role);
                    if (UpdateDocumentsInProgress(-1) == 0)
                    {
                        if (!Cancelled)
                        {
                            OnDiscoverInfo("Building", "Report");
                            BuildReport(filename);
                            OnDiscoverReady("Completed", "");
                        }
                        else
                            OnDiscoverWarning("Discovery cancelled by user", filename);
                    }
                }
            }
            catch (Exception e)
            {
                OnDiscoverError(e.Message, filename);
            }
        }
        public void DiscoverSchema(Entities.xml.Document document)
        {
            if (!Schemas.TryAdd(document.Filename, new Entities.xs.Schema(document)))
                throw new Exception();
        }
        public void DiscoverLinkbase(Entities.xml.Document document, string role = null)
        {
            if (!Linkbases.TryAdd(document.Filename, new Entities.link.Linkbase(document, role)))
                throw new Exception();
        }
        public void BuildReport(string filename)
        {
            Report.RgsEntrypoint = filename;
            foreach (Entities.xml.Document rgsDocument in Nodes)
            {
                if (rgsDocument.IsLinkbase)
                {
                    Entities.link.Linkbase linkbase = (Entities.link.Linkbase)rgsDocument.Root;
                    foreach (Entities.xl.ExtendedLink extendedLink in linkbase.ExtendedLinks)
                    {
                        foreach (Entities.xl.Arc arc in extendedLink.Arcs)
                            arc.From.Href.Element.RelatedArcs.Add(arc);
                    }
                }
            }
            foreach (Entities.xml.Document rgsDocument in Nodes)
            {
                if (rgsDocument.IsSchema)
                {
                    Entities.xs.Schema schema = (Entities.xs.Schema)rgsDocument.Root;
                    Report.Schemas.Add(new Schema() { Location = rgsDocument.Filename, Namespace = schema.TargetNamespaceAttrbiute, Prefix = QName.XmlNamespaceManager.LookupPrefix(schema.TargetNamespaceAttrbiute) });
                }
                else if (rgsDocument.IsLinkbase)
                {
                    Entities.link.Linkbase linkbase = (Entities.link.Linkbase)rgsDocument.Root;
                    foreach (Entities.xl.ExtendedLink rgsLink in linkbase.ExtendedLinks)
                    {
                        Linkrole linkrole = new Linkrole() { Uri = rgsLink.RoleAttribute };
                        foreach (var datapointArc in rgsLink.Arcs.OfType<Entities.rgs15.DatapointArc>())
                        {
                            var mapping = new RGS.Mapping.Model.v2015.Mapping();
                            Entities.rgs15.Datapoint rgsFrom = datapointArc.From;
                            mapping.From = new Datapoint();
                            mapping.From.Primary = new Primary() { QName = rgsFrom.Entrypoint.Primary.QNameAttribute, Label = GetStandardLabel(rgsFrom.Entrypoint.Primary.Concept) };
                            if (!SimpleReport)
                            {
                                foreach (Entities.rgs15.ExplicitDimension rgsExplicitDimension in rgsFrom.Entrypoint.Primary.ExplicitDimensions)
                                    mapping.From.Primary.ExplicitDimensions.Add(new ExplicitDimension() { QName = rgsExplicitDimension.QNameAttribute, Label = GetStandardLabel(rgsExplicitDimension.Concept), Member = rgsExplicitDimension.MemberAttribute == default ? default : new Concept() { QName = rgsExplicitDimension.MemberAttribute, Label = GetStandardLabel(rgsExplicitDimension.Member) } });
                                foreach (Entities.rgs15.TypedDimension rgsTypedDimension in rgsFrom.Entrypoint.Primary.TypedDimensions)
                                    mapping.From.Primary.TypedDimensions.Add(new TypedDimension() { QName = rgsTypedDimension.QNameAttribute, Label = GetStandardLabel(rgsTypedDimension.Concept) });
                            }
                            Entities.rgs15.Datapoint rgsTo = datapointArc.To;
                            if (Report.NtEntrypoint != default && Report.NtEntrypoint != rgsFrom.Entrypoint.URIAttribute)
                                OnDiscoverWarning("Multiple NT entrypoints discovered. Uri {0} is ingored.", rgsFrom.Entrypoint.URIAttribute);
                            Report.NtEntrypoint = rgsFrom.Entrypoint.URIAttribute;
                            mapping.To = new Datapoint();
                            mapping.To.Primary = new Primary() { QName = rgsTo.Entrypoint.Primary.QNameAttribute, Label = GetStandardLabel(rgsTo.Entrypoint.Primary.Concept) };
                            if (!SimpleReport)
                            {
                                foreach (Entities.rgs15.ExplicitDimension rgsExplicitDimension in rgsTo.Entrypoint.Primary.ExplicitDimensions)
                                    mapping.To.Primary.ExplicitDimensions.Add(new ExplicitDimension() { QName = rgsExplicitDimension.QNameAttribute, Label = GetStandardLabel(rgsExplicitDimension.Concept), Member = rgsExplicitDimension.MemberAttribute == default ? default : new Concept() { QName = rgsExplicitDimension.MemberAttribute, Label = GetStandardLabel(rgsExplicitDimension.Member) } });
                                foreach (Entities.rgs15.TypedDimension rgsTypedDimension in rgsTo.Entrypoint.Primary.TypedDimensions)
                                    mapping.To.Primary.TypedDimensions.Add(new TypedDimension() { QName = rgsTypedDimension.QNameAttribute, Label = GetStandardLabel(rgsTypedDimension.Concept) });
                            }
                            linkrole.Mappings.Add(mapping);
                        }
                        foreach (var datapointArc in rgsLink.Arcs.OfType<Entities.gen.Arc>().Where(item=>item.ArcroleAttribute== @"http://www.nltaxonomie.nl/rgs/2022/arcrole/mapping"))
                        {
                            var mapping = new RGS.Mapping.Model.v2022.Mapping();
                            Entities.link.Loc rgsFrom = (Entities.link.Loc)datapointArc.From;
                            mapping.From = new Concept();
                            mapping.From.QName = ((Entities.xs.Element)rgsFrom.Href.Element).NameAttribute;
                            mapping.From.Label = GetStandardLabel((Entities.xs.Element)rgsFrom.Element);
                            Entities.rgs22.Datapoint rgsTo = (Entities.rgs22.Datapoint)datapointArc.To;
                            mapping.To = new Datapoint();
                            mapping.To.Primary = new Primary() { QName = rgsTo.Primary.QNameAttribute, Label = GetStandardLabel(rgsTo.Primary.Concept) };
                            if (!SimpleReport)
                            {
                                foreach (Entities.rgs22.ExplicitDimension rgsExplicitDimension in rgsTo.Primary.ExplicitDimensions)
                                    mapping.To.Primary.ExplicitDimensions.Add(new ExplicitDimension() { QName = rgsExplicitDimension.QNameAttribute, Label = GetStandardLabel(rgsExplicitDimension.Concept), Member = rgsExplicitDimension.MemberAttribute == default ? default : new Concept() { QName = rgsExplicitDimension.MemberAttribute, Label = GetStandardLabel(rgsExplicitDimension.Member) } });
                                foreach (Entities.rgs22.TypedDimension rgsTypedDimension in rgsTo.Primary.TypedDimensions)
                                    mapping.To.Primary.TypedDimensions.Add(new TypedDimension() { QName = rgsTypedDimension.QNameAttribute, Label = GetStandardLabel(rgsTypedDimension.Concept) });
                            }
                            linkrole.Mappings.Add(mapping);
                        }
                        if (linkrole.Mappings.Count > 0)
                            Report.Linkroles.Add(linkrole);
                    }
                }
            }
        }
        public string GetStandardLabel(Entities.xs.Element element) =>
            element.RelatedArcs.OfType<Entities.link.LabelArc>().FirstOrDefault(item => item.To.LangAttribute == "nl" && item.To.RoleAttribute == @"http://www.xbrl.org/2003/role/label")?.To.Value;
        public static string ResolveAbsoluteTargetLocation(string targetLocation, string baseLocation)
        {
            Uri baseUri = new Uri(baseLocation);
            Uri targetUri = Href.GetUriFromHrefString(targetLocation);
            if (!targetUri.IsAbsoluteUri)
            {
                XmlUrlResolver resolver = new XmlUrlResolver();
                targetUri = resolver.ResolveUri(baseUri, targetUri.OriginalString);
            }
            return targetUri.AbsoluteUri;
        }

        public void schemaSet_ValidationEventHandler(object sender, ValidationEventArgs e) => ValidationProblem?.Invoke(this, e);

        public void OnDiscoverInfo(string action, string message, [CallerMemberName] string callerNemberName = default, [CallerFilePath] string callerFilePath = default, [CallerLineNumber] int callerLineNumber = default)
            => DiscoverInfo?.Invoke(this, new ActivityEventArgs(action, message, callerNemberName, callerFilePath, callerLineNumber));
        public void OnDiscoverWarning(string action, string message, [CallerMemberName] string callerNemberName = default, [CallerFilePath] string callerFilePath = default, [CallerLineNumber] int callerLineNumber = default)
            => DiscoverWarning?.Invoke(this, new ActivityEventArgs(action, message, callerNemberName, callerFilePath, callerLineNumber));
        public void OnDiscoverError(string action, string message, [CallerMemberName] string callerNemberName = default, [CallerFilePath] string callerFilePath = default, [CallerLineNumber] int callerLineNumber = default)
            => DiscoverError?.Invoke(this, new ActivityEventArgs(action, message, callerNemberName, callerFilePath, callerLineNumber));
        public void OnDiscoverReady(string action, string message, [CallerMemberName] string callerNemberName = default, [CallerFilePath] string callerFilePath = default, [CallerLineNumber] int callerLineNumber = default)
            => DiscoverReady?.Invoke(this, new ActivityEventArgs(action, message, callerNemberName, callerFilePath, callerLineNumber));

        public delegate void DtsValidationEventHandler(object sender, ValidationEventArgs e);
        public event DtsValidationEventHandler ValidationProblem;

        public delegate void DtsActivityEventHandler(object sender, ActivityEventArgs e);
        public event DtsActivityEventHandler DiscoverInfo;
        public event DtsActivityEventHandler DiscoverWarning;
        public event DtsActivityEventHandler DiscoverError;
        public event DtsActivityEventHandler DiscoverReady;
    }

    public class ActivityEventArgs : EventArgs
    {
        public string Action { get; }
        public string Message { get; }
        public string CallerMemberName { get; }
        public string CallerFilePath { get; }
        public int CallerLineNumber { get; }
        public ActivityEventArgs(string action, string message, string callerMemberName = default, string callerFilePath = default, int callerLineNumber = default)
        {
            Action = action;
            Message = message;
            CallerMemberName = callerMemberName;
            CallerFilePath = callerFilePath;
            CallerLineNumber = callerLineNumber;
        }
    }
}
