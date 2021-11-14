using System.Xml.Linq;

namespace Xbrl.Discovery.Entities.xl
{
    public class SimpleLink : xml.Element
    {
        /*<schema
          xmlns = "http://www.w3.org/2001/XMLSchema" targetNamespace="http://www.xbrl.org/2003/XLink" elementFormDefault="qualified" attributeFormDefault="unqualified">
        <complexType name = "simpleType" >
        < annotation >
        < documentation >
        Type for the simple links defined in XBRL
        </documentation>
        </annotation>
        <complexContent>
        <restriction base="anyType">
        <attributeGroup ref="xlink:simpleType"/>
        <attribute ref="xlink:href" use="required"/>
        <attribute ref="xlink:arcrole" use="optional"/>
        <attribute ref="xlink:role" use="optional"/>
        <attribute ref="xlink:title" use="optional"/>
        <attribute ref="xlink:show" use="optional"/>
        <attribute ref="xlink:actuate" use="optional"/>
        <anyAttribute namespace="http://www.w3.org/XML/1998/namespace" processContents="lax"/>
        </restriction>
        </complexContent>
        </complexType>
        <element name = "simple" type="xl:simpleType" abstract="true">
        <annotation>
        <documentation>
        The abstract element at the head of the simple link substitution group.
        </documentation>
        </annotation>
        </element>
        </schema>*/
        public static new RGS.Mapping.Model.QName QName => Namespaces.xl + "simple";

        public virtual string TypeAttribute => Attribute(Namespaces.xlink + "type")?.Value;
        public virtual string HrefAttribute => Attribute(Namespaces.xlink + "href")?.Value;
        public virtual string RoleAttribute => Attribute(Namespaces.xlink + "role")?.Value;
        public virtual string ArcroleAttribute => Attribute(Namespaces.xlink + "arcrole")?.Value;
        public virtual string TitleAttribute => Attribute(Namespaces.xlink + "title")?.Value;
        public virtual string ShowAttribute => Attribute(Namespaces.xlink + "show")?.Value;
        public virtual string ActuateAttribute => Attribute(Namespaces.xlink + "actuate")?.Value;
        public virtual string BaseAttribute => Attribute(Namespaces.xml + "base")?.Value;

        public SimpleLink(xml.Element parent, XElement xElement) : base(parent, xElement)
        { }
    }
}
