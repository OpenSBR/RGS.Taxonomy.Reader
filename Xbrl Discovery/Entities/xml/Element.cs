using RGS.Mapping.Model;
using System;
using System.Collections.Generic;
using System.Xml.Linq;

namespace Xbrl.Discovery.Entities.xml
{
    public class Element : Container<XElement>
    {
        public static QName QName => Namespaces.xml + "element";

        public virtual Document Document => Parent is Document document ? document : ParentElement?.Document;
        public virtual Element RootElement => Document?.Root;
        public virtual Element ParentElement => Parent as Element;

        public string IdAttribute => Attribute("id")?.Value;
        public QName Name => XObject.Name;
        public string Value => XObject.Value;
        public List<Element> CustomElements { get; } = new List<Element>();
        public List<xsi.SchemaLocation> SchemaLocations { get; } = new List<xsi.SchemaLocation>();
        public List<xl.Arc> RelatedArcs = new List<xl.Arc>();
        public virtual Href Href { get; }

        public Element(Document parent) : base(parent, parent.XObject.Root)
        {
            Document.Root = this;
            if (IdAttribute != default)
            {
                Href = new Href(Dts, new Uri(Document.Filename), IdAttribute);
                Document.Elements.TryAdd(Href.Value, this);
            }
            foreach (XAttribute item in Attributes())
                foreach (XAttribute xAttribute in Attributes())
                ProcessAttribute(xAttribute);
            foreach (XElement xElement in Elements())
                ProcessElement(xElement);
        }
        public Element(Element parent, XElement xElement) : base(parent, xElement)
        {
            if (IdAttribute != default)
            {
                Href = new Href(Dts, new Uri(Document.Filename), IdAttribute);
                Document.Elements.TryAdd(Href.Value, this);
            }
            foreach (XAttribute item in Attributes())
                ProcessAttribute(item);
            foreach (XElement item in Elements())
                ProcessElement(item);
        }
        public void ProcessAttribute(XAttribute xAttribute)
        {
            if (xAttribute.IsNamespaceDeclaration && xAttribute.Name.LocalName != "xmlns")
                QName.XmlNamespaceManager.AddNamespace(xAttribute.Name.LocalName, xAttribute.Value);
            if (xAttribute.Name == xsi.SchemaLocation.QName)
                SchemaLocations.Add(new xsi.SchemaLocation(this, xAttribute));
        }
        public virtual void ProcessElement(XElement xElement)
        {
            Element item;
            Type type = ResolveType(xElement.Name);
            if (type != default)
                item = (Element)Activator.CreateInstance(type, this, xElement);
            else
                item = new Element(this, xElement);
            CustomElements.Add(item);
        }

        public Type ResolveType(XName xName)
        {
            Type result = default;
            if (Dts.BuiltInTypes.ContainsKey(xName))
                result = Dts.BuiltInTypes[xName];
            return result;
        }
        public xs.Element ResolveXsElement(QName name)
        {
            xs.Element result = default;
            if (Dts.GlobalXsElements.ContainsKey(name))
                result = Dts.GlobalXsElements[name];
            return result;
        }

        public virtual XAttribute Attribute(XName name) => XObject.Attribute(name);
        public virtual IEnumerable<XAttribute> Attributes() => XObject.Attributes();
        public virtual IEnumerable<XAttribute> Attributes(XName name) => XObject.Attributes(name);
        public virtual XElement Child(XName name) => XObject.Element(name);
        public virtual IEnumerable<XElement> Elements() => XObject.Elements();
        public virtual IEnumerable<XElement> Elements(XName name) => XObject.Elements(name);
        public virtual IEnumerable<XElement> Descendants() => XObject.Descendants();
        public virtual IEnumerable<XElement> Descendants(XName name) => XObject.Descendants(name);
    }
}