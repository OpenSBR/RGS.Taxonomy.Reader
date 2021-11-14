using System.Collections.Generic;
using System.Xml.Linq;

namespace Xbrl.Discovery.Entities.link
{
    public class RoleType : xml.Element
    {
        /*<schema 
          xmlns:link="http://www.xbrl.org/2003/linkbase" 
          xmlns="http://www.w3.org/2001/XMLSchema" targetNamespace="http://www.xbrl.org/2003/linkbase" elementFormDefault="qualified">
        <element name="roleType">
        <annotation>
        <documentation>
        The roleType element definition - used to define custom role values in XBRL extended links.
        </documentation>
        </annotation>
        <complexType>
        <sequence>
        <element ref="link:definition" minOccurs="0"/>
        <element ref="link:usedOn" maxOccurs="unbounded"/>
        </sequence>
        <attribute name="roleURI" type="xlink:nonEmptyURI" use="required"/>
        <attribute name="id" type="ID"/>
        </complexType>
        </element>
        </schema>*/
        public static new RGS.Mapping.Model.QName QName => Namespaces.link + "roleType";

        public virtual string RoleURIAttribute => Attribute("roleURI")?.Value;
        
        public Definition Definition { get; protected set; }
        public List<UsedOn> UsedOns { get; } = new List<UsedOn>();

        public RoleType(xs.Appinfo parent, XElement xElement) : base(parent, xElement)
        { }

        public override void ProcessElement(XElement xElement)
        {
            if (Definition == null && xElement.Name == Definition.QName)
                Definition = new Definition(this, xElement);
            else if (xElement.Name == UsedOn.QName)
                UsedOns.Add(new UsedOn(this, xElement));
            else
                base.ProcessElement(xElement);
        }

    }
}
