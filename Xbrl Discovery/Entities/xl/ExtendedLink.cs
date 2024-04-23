using System.Collections.Generic;
using System.Xml.Linq;

namespace Xbrl.Discovery.Entities.xl
{
    public class ExtendedLink : xml.Element
    {
        /*<schema
          xmlns = "http://www.w3.org/2001/XMLSchema" targetNamespace="http://www.xbrl.org/2003/XLink" elementFormDefault="qualified" attributeFormDefault="unqualified">
        <complexType name = "extendedType" >
        < annotation >
        < documentation >
        Generic extended link type
        </documentation>
        </annotation>
        <complexContent>
        <restriction base="anyType">
        <choice minOccurs = "0" maxOccurs="unbounded">
        <element ref="xl:title"/>
        <element ref="xl:documentation"/>
        <element ref="xl:locator"/>
        <element ref="xl:arc"/>
        <element ref="xl:resource"/>
        </choice>
        <attributeGroup ref="xlink:extendedType"/>
        <attribute ref="xlink:role" use="required"/>
        <attribute ref="xlink:title" use="optional"/>
        <attribute name = "id" type="ID" use="optional"/>
        <anyAttribute namespace="http://www.w3.org/XML/1998/namespace" processContents="lax"/>
        </restriction>
        </complexContent>
        </complexType>
        <element name = "extended" type="xl:extendedType" abstract="true">
        <annotation>
        <documentation>
        Abstract extended link element at head of extended link substitution group.
        </documentation>
        </annotation>
        </element>
        </schema>*/
        public static new RGS.Mapping.Model.QName QName => Namespaces.xl + "extended";

        public virtual string RoleAttribute => Attribute(Namespaces.xlink + "role")?.Value;
        public virtual string TitleAttribute => Attribute(Namespaces.xlink + "title")?.Value;

        public List<link.Documentation> Documentations { get; } = new List<link.Documentation>();
        public List<Title> Titles { get; } = new List<Title>();
        public Dictionary<string, Resource> Resources { get; } = new Dictionary<string, Resource>();
        public List<Arc> Arcs { get; } = new List<Arc>();
        public List<label.Label> Labels { get; } = new List<label.Label>();

        protected ExtendedLink(link.Linkbase parent, XElement xElement) : base(parent, xElement)
        {
            parent.ExtendedLinks.Add(this);
        }

        public override void ProcessElement(XElement xElement)
        {
            if (xElement.Name == link.Documentation.QName)
                Documentations.Add(new link.Documentation(this, xElement));
            else if (xElement.Name == Title.QName)
                Titles.Add(new Title(this, xElement));
            else
                base.ProcessElement(xElement);
        }

        public Resource GetResource(string id)
        {
            if (Resources.TryGetValue(id, out Resource resource))
                return resource;

            return null;
        }
    }

    public class ExtendedLink<ArcType> : ExtendedLink
        where ArcType : Arc
    {
        protected ExtendedLink(link.Linkbase parent, XElement xElement) : base(parent, xElement)
        { }

        public new IEnumerable<ArcType> Arcs => (IEnumerable<ArcType>)base.Arcs;
    }
}
