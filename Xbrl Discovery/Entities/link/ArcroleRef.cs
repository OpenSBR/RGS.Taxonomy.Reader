using System.Xml.Linq;

namespace Xbrl.Discovery.Entities.link
{
    public class ArcroleRef : xl.SimpleLink
    {
        /*<schema
          xmlns:link="http://www.xbrl.org/2003/linkbase" 
          xmlns="http://www.w3.org/2001/XMLSchema" targetNamespace="http://www.xbrl.org/2003/linkbase" elementFormDefault="qualified">
        <element name = "arcroleRef" substitutionGroup="xl:simple">
        <annotation>
        <documentation>
        Definition of the roleRef element - used to link to resolve xlink:arcrole attribute values to the arcroleType element declaration.
        </documentation>
        </annotation>
        <complexType>
        <complexContent>
        <extension base="xl:simpleType">
        <attribute name = "arcroleURI" type= "xlink:nonEmptyURI" use= "required" >
        < annotation >
        < documentation >
        This attribute contains the arc role name.
        </documentation>
        </annotation>
        </attribute>
        </extension>
        </complexContent>
        </complexType>
        </element>
        </schema>*/
        public static new RGS.Mapping.Model.QName QName => Namespaces.link + "arcroleRef";

        public virtual string ArcroleURIAttribute => Attribute("arcroleURI")?.Value;

        public ArcroleRef(Linkbase parent, XElement xElement) : base(parent, xElement)
        { }
    }
}
