using System.Xml;
using System.Xml.Linq;

namespace Xbrl.Discovery.Entities.xsi
{
    public class Type : xml.Attribute
    {
        public Type(xml.Element parent, XAttribute xAttribute) : base(parent, xAttribute)
        { }
        public Type(xml.Element parent, XmlAttribute xmlAttribute) : this(parent, new XAttribute(XName.Get(xmlAttribute.LocalName, xmlAttribute.NamespaceURI), xmlAttribute.Value))
        { }
    }
}