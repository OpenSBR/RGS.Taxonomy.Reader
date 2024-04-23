using System.Collections.Generic;
using System.Xml.Linq;

namespace Xbrl.Discovery.Entities.xl
{
    public class Arc : xml.Element
    {
        /*<schema
          xmlns = "http://www.w3.org/2001/XMLSchema" targetNamespace="http://www.xbrl.org/2003/XLink" elementFormDefault="qualified" attributeFormDefault="unqualified">
        <simpleType name = "useEnum" >
        < annotation >
        < documentation >
        Enumerated values for the use attribute on extended link arcs.
        </documentation>
        </annotation>
        <restriction base="NMTOKEN">
        <enumeration value = "optional" />
        < enumeration value="prohibited"/>
        </restriction>
        </simpleType>
        <complexType name = "arcType" >
        < annotation >
        < documentation >
        basic extended link arc type - extended where necessary for specific arcs Extends the generic arc type by adding use, priority and order attributes.
        </documentation>
        </annotation>
        <complexContent>
        <restriction base="anyType">
        <sequence>
        <element ref="xl:title" minOccurs="0" maxOccurs="unbounded"/>
        </sequence>
        <attributeGroup ref="xlink:arcType"/>
        <attribute ref="xlink:from" use="required"/>
        <attribute ref="xlink:to" use="required"/>
        <attribute ref="xlink:arcrole" use="required"/>
        <attribute ref="xlink:title" use="optional"/>
        <attribute ref="xlink:show" use="optional"/>
        <attribute ref="xlink:actuate" use="optional"/>
        <attribute name = "order" type="decimal" use="optional"/>
        <attribute name = "use" type="xl:useEnum" use="optional"/>
        <attribute name = "priority" type="integer" use="optional"/>
        <anyAttribute namespace="##other" processContents="lax"/>
        </restriction>
        </complexContent>
        </complexType>
        <element name = "arc" type="xl:arcType" abstract="true">
        <annotation>
        <documentation>
        Abstract element to use as head of arc element substitution group.
        </documentation>
        </annotation>
        </element>
        </schema>*/
        public new ExtendedLink ParentElement => (ExtendedLink)base.ParentElement;

        public List<Title> Titles => new List<Title>();

        public string TypeAttribute => Attribute(Namespaces.xlink + "type")?.Value;
        public string FromAttribute => Attribute(Namespaces.xlink + "from")?.Value;
        public string ToAttribute => Attribute(Namespaces.xlink + "to")?.Value;
        public string ArcroleAttribute => Attribute(Namespaces.xlink + "arcrole")?.Value;
        public string TitleAttribute => Attribute(Namespaces.xlink + "title")?.Value;
        public string ShowAttribute => Attribute(Namespaces.xlink + "show")?.Value;
        public string ActuateAttribute => Attribute(Namespaces.xlink + "actuate")?.Value;
        public string OrderAttribute => Attribute("order")?.Value;
        //Use = prohibited om dingen te overriden (subtotal)
        public string UseAttribute => Attribute("use")?.Value;
        public string PriorityAttribute => Attribute("priority")?.Value;

        protected Resource _from;
        public Resource From
        {
            get
            {
                if (_from == default)
                    _from = ParentElement.GetResource(FromAttribute);
                return _from;
            }
        }
        protected Resource _to;
        public Resource To
        {
            get
            {
                if (_to == default)
                    _to = ParentElement.GetResource(ToAttribute);
                return _to;
            }
        }

        public Arc(ExtendedLink parent, XElement xElement) : base(parent, xElement)
        {
            parent.Arcs.Add(this);
        }

        public override void ProcessElement(XElement xElement)
        {
            if (xElement.Name == Title.QName)
                Titles.Add(new Title(this, xElement));
            else
                base.ProcessElement(xElement);
        }
    }

    public class Arc<FromType, ToType> : Arc
        where FromType : Resource
        where ToType : Resource
    {
        public new FromType From => (FromType)base.From;
        public new ToType To => (ToType)base.To;

        public Arc(ExtendedLink parent, XElement xElement) : base(parent, xElement)
        { }
    }
}
