using RGS.Mapping.Model;
using System.Text.RegularExpressions;
using System.Xml;
using System.Xml.Linq;

namespace Xbrl.Discovery.Entities.xsi
{
    public class SchemaLocation : xml.Attribute
    {
        public static new QName QName => Namespaces.xsi + "schemaLocation";

        public SchemaLocation(xml.Element parent, XmlAttribute xmlAttribute) : this(parent, new XAttribute(XName.Get(xmlAttribute.LocalName, xmlAttribute.NamespaceURI), xmlAttribute.Value)) { }
        public SchemaLocation(xml.Element parent, XAttribute xAttribute) : base(parent, xAttribute)
        {
            string[] uris = Regex.Replace(Value?.Trim(), @"\s+", " ")?.Split(' ');
            for (int index = 0; index < uris?.Length; index += 2)
            {
                if (uris[index] != string.Empty)
                    Dts.DiscoverDocument(Dts.ResolveAbsoluteTargetLocation(uris[index + 1], Document.Filename));
            }
            for (int index = 0; index < uris?.Length; index += 2)
            {
                if (uris[index] != string.Empty)
                    Dts.DiscoverDocument(Dts.ResolveAbsoluteTargetLocation(uris[index + 1], Document.Filename));
            }
        }
    }
}