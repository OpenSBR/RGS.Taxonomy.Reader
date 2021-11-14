using System.Collections.Generic;
using System.Xml.Linq;

namespace Xbrl.Discovery.Entities.link
{
    public class Linkbase : xml.Element
    {
        /*<schema
          xmlns:link="http://www.xbrl.org/2003/linkbase" 
          xmlns="http://www.w3.org/2001/XMLSchema" targetNamespace="http://www.xbrl.org/2003/linkbase" elementFormDefault="qualified">
        <element name = "linkbase" >
        < annotation >
        < documentation >
        Definition of the linkbase element.Used to contain a set of zero or more extended link elements.
        </documentation>
        </annotation>
        <complexType>
        <choice minOccurs = "0" maxOccurs= "unbounded" >
        < element ref= "link:documentation" />
        < element ref= "link:roleRef" />
        < element ref= "link:arcroleRef" />
        < element ref= "xl:extended" />
        </ choice >
        < attribute name= "id" type= "ID" use= "optional" />
        < anyAttribute namespace="http://www.w3.org/XML/1998/namespace" processContents="lax"/>
        </complexType>
        </element>
        </schema>*/
        public static new RGS.Mapping.Model.QName QName => Namespaces.link + "linkbase";

        public virtual string LinkbaseRefRole { get; }
        public virtual string BaseAttribute => Attribute(Namespaces.xml + "base")?.Value;

        public List<Documentation> Documentations { get; } = new List<Documentation>();
        public List<RoleRef> RoleRefs { get; } = new List<RoleRef>();
        public List<ArcroleRef> ArcroleRefs { get; } = new List<ArcroleRef>();
        public virtual List<xl.ExtendedLink> ExtendedLinks { get; } = new List<xl.ExtendedLink>();

        public Linkbase(xml.Document parent, string linkbaseRefRole) : base(parent)
        {
            LinkbaseRefRole = linkbaseRefRole;
        }
        public Linkbase(xs.Appinfo parent, XElement xElement) : base(parent, xElement)
        { }

        public override void ProcessElement(XElement xElement)
        {
            if (xElement.Name == Documentation.QName)
                Documentations.Add(new Documentation(this, xElement));
            else if (xElement.Name == RoleRef.QName)
                RoleRefs.Add(new RoleRef(this, xElement));
            else if (xElement.Name == ArcroleRef.QName)
                ArcroleRefs.Add(new ArcroleRef(this, xElement));
            else if (xElement.Name == LabelLink.QName)
                _ = new LabelLink(this, xElement);
            else if (xElement.Name == ReferenceLink.QName)
                _ = new ReferenceLink(this, xElement);
            else if (xElement.Name == CalculationLink.QName)
                _ = new CalculationLink(this, xElement);
            else if (xElement.Name == PresentationLink.QName)
                _ = new PresentationLink(this, xElement);
            else if (xElement.Name == DefinitionLink.QName)
                _ = new DefinitionLink(this, xElement);
            else if (xElement.Name == gen.Link.QName)
                _ = new gen.Link(this, xElement);
            else
                base.ProcessElement(xElement);
        }
    }
}
