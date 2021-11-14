using System.Xml.Linq;

namespace Xbrl.Discovery.Entities.link
{
    public class LinkbaseRef : xl.SimpleLink
    {
        /*<schema
          xmlns:link="http://www.xbrl.org/2003/linkbase" 
          xmlns="http://www.w3.org/2001/XMLSchema" targetNamespace="http://www.xbrl.org/2003/linkbase" elementFormDefault="qualified">
        <element name = "linkbaseRef" substitutionGroup="xl:simple">
        <annotation>
        <documentation>
        Definition of the linkbaseRef element - used to link to XBRL taxonomy extended links from taxonomy schema documents and from XBRL instances.
        </documentation>
        </annotation>
        <complexType>
        <complexContent>
        <restriction base="xl:simpleType">
        <attribute ref= "xlink:arcrole" use= "required" >
        < annotation >
        < documentation >
        This attribute must have the value: http://www.w3.org/1999/xlink/properties/linkbase
        </documentation>
        </annotation>
        </attribute>
        <anyAttribute namespace="http://www.w3.org/XML/1998/namespace" processContents="lax"/>
        </restriction>
        </complexContent>
        </complexType>
        </element>
        </schema>*/
        public static new RGS.Mapping.Model.QName QName => Namespaces.link + "linkbaseRef";

        public LinkbaseRef(xs.Appinfo parent, XElement xElement) : base(parent, xElement)
        {
            Dts.DiscoverDocument(Dts.ResolveAbsoluteTargetLocation(base.HrefAttribute, base.Document.Filename), RoleAttribute);
        }
    }
}
