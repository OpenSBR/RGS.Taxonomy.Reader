using System.Xml;
using System.Xml.Linq;

namespace Xbrl.Discovery.Entities.xml
{
    public class Attribute : Entity<XAttribute>
    {
        public static RGS.Mapping.Model.QName QName => Namespaces.xml + "attribute";

        public virtual Document Document => ParentElement?.Document;
        public virtual Element RootElement => Document?.Root;
        public virtual Element ParentElement => Parent as Element;

        public RGS.Mapping.Model.QName Name => XObject.Name;
        public string Value => XObject.Value;

        public Attribute(Element parent, XAttribute xAttribute) : base(parent, xAttribute)
        { }
        public Attribute(Element parent, XmlAttribute xmlAttribute) : this(parent, new XAttribute(XName.Get(xmlAttribute.LocalName, xmlAttribute.NamespaceURI), xmlAttribute.Value))
        { }
    }
}
