using System.Text.RegularExpressions;
using System.Xml;
using System.Xml.Linq;

namespace Xbrl.Discovery.Entities.xsi
{
    public class NoNamespaceSchemaLocation : xml.Attribute
    {
        public static new RGS.Mapping.Model.QName QName => Namespaces.xsi + "noNamespaceSchemaLocation";

        public NoNamespaceSchemaLocation(xml.Element parent, XmlAttribute xmlAttribute) : this(parent, new XAttribute(XName.Get(xmlAttribute.LocalName, xmlAttribute.NamespaceURI), xmlAttribute.Value)) { }
        public NoNamespaceSchemaLocation(xml.Element parent, XAttribute xAttribute) : base(parent, xAttribute)
        {
            string[] uris = Regex.Replace(Value?.Trim(), @"\s+", " ")?.Split(' ');
            for (int index = 0; index < uris?.Length; index++)
            {
                if (uris[index] != string.Empty)
                    Dts.DiscoverDocument(Dts.ResolveAbsoluteTargetLocation(uris[index], Document.Filename));
            }
        }
    }
}