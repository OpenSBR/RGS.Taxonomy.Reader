using System.Xml.Linq;

namespace Xbrl.Discovery.Entities.xl
{
    public class Title : xml.Element
    {
        /*<schema
          xmlns = "http://www.w3.org/2001/XMLSchema" targetNamespace="http://www.xbrl.org/2003/XLink" elementFormDefault="qualified" attributeFormDefault="unqualified">
        <complexType name = "titleType" >
        < annotation >
        < documentation >
        Type for the abstract title element - used as a title element template.
        </documentation>
        </annotation>
        <complexContent>
        <restriction base="anyType">
        <attributeGroup ref= "xlink:titleType" />
        </ restriction >
        </ complexContent >
        </ complexType >
        < element name= "title" type= "xl:titleType" abstract="true">
        <annotation>
        <documentation>
        Generic title element for use in extended link documentation.Used on extended links, arcs, locators. See http://www.w3.org/TR/xlink/#title-element for details.
        </documentation>
        </annotation>
        </element>
        </schema>*/
        public static new RGS.Mapping.Model.QName QName => Namespaces.xl + "title";

        public virtual string LanguageAttribute => Attribute(Namespaces.xml + "language")?.Value;

        public Title(Arc parent, XElement xElement) : base(parent, xElement)
        { }

        public Title(link.Loc parent, XElement xElement) : base(parent, xElement)
        { }

        public Title(ExtendedLink parent, XElement xElement) : base(parent, xElement)
        { }
    }
}
