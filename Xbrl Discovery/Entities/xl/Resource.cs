using System.Xml.Linq;

namespace Xbrl.Discovery.Entities.xl
{
    //TODO abstract
    public class Resource : xml.Element
    {
        /*<schema
          xmlns = "http://www.w3.org/2001/XMLSchema" targetNamespace="http://www.xbrl.org/2003/XLink" elementFormDefault="qualified" attributeFormDefault="unqualified">
        <complexType name = "resourceType" >
        < annotation >
        < documentation >
        Generic type for the resource type element
        </documentation>
        </annotation>
        <complexContent mixed = "true" >
        < restriction base="anyType">
        <attributeGroup ref= "xlink:resourceType" />
        < attribute ref= "xlink:label" use= "required" />
        < attribute ref= "xlink:role" use= "optional" />
        < attribute ref= "xlink:title" use= "optional" />
        < attribute name= "id" type= "ID" use= "optional" />
        </ restriction >
        </ complexContent >
        </ complexType >
        < element name= "resource" type= "xl:resourceType" abstract="true">
        <annotation>
        <documentation>
        Abstract element to use as head of resource element substitution group.
        </documentation>
        </annotation>
        </element>
        </schema>*/
        public static new RGS.Mapping.Model.QName QName => Namespaces.xl + "resource";

        //public virtual XbrlModel.Entities.Entity Entity { get; protected set; }

        public string LabelAttribute => Attribute(Namespaces.xlink + "label")?.Value;
        public string RoleAttribute => Attribute(Namespaces.xlink + "role")?.Value;
        public string TitleAttribute => Attribute(Namespaces.xlink + "title")?.Value;
        
        public Resource(ExtendedLink parent, XElement xElement) : base(parent, xElement)
        {
            parent.Resources.Add(LabelAttribute, this);
        }
    }
}
