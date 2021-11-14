using System.Xml;
using System.Xml.Linq;

namespace Xbrl.Discovery.Entities.xsi
{
    public class Nil : xml.Attribute
    {
        public Nil(xml.Element parent, XAttribute xAttribute) : base(parent, xAttribute)
        { }
        public Nil(xml.Element parent, XmlAttribute xmlAttribute) : this(parent, new XAttribute(XName.Get(xmlAttribute.LocalName, xmlAttribute.NamespaceURI), xmlAttribute.Value))
        { }
    }
}