using System.Xml.Linq;


namespace Xbrl.Discovery.Entities.link
{
    public class RoleRef : xl.SimpleLink
    {
        /*<schema
          xmlns:link="http://www.xbrl.org/2003/linkbase" 
          xmlns="http://www.w3.org/2001/XMLSchema" targetNamespace="http://www.xbrl.org/2003/linkbase" elementFormDefault="qualified">
        <element name = "roleRef" substitutionGroup="xl:simple">
        <annotation>
        <documentation>
        Definition of the roleRef element - used to link to resolve xlink:role attribute values to the roleType element declaration.
        </documentation>
        </annotation>
        <complexType>
        <complexContent>
        <extension base="xl:simpleType">
        <attribute name = "roleURI" type= "xlink:nonEmptyURI" use= "required" >
        < annotation >
        < documentation >
        This attribute contains the role name.
        </documentation>
        </annotation>
        </attribute>
        </extension>
        </complexContent>
        </complexType>
        </element>
        </schema>*/
        public static new RGS.Mapping.Model.QName QName => Namespaces.link + "roleRef";

        public virtual string RoleURIAttribute => Attribute("roleURI")?.Value;

        public RoleRef(Linkbase parent, XElement xElement) : base(parent, xElement)
        {
            Dts.DiscoverDocument(Dts.ResolveAbsoluteTargetLocation(HrefAttribute, Document.Filename));
        }
    }
}
