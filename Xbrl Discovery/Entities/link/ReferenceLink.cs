using System.Xml.Linq;

namespace Xbrl.Discovery.Entities.link
{
    public class ReferenceLink : xl.ExtendedLink<ReferenceArc>
    {
        /*<schema
          xmlns:link="http://www.xbrl.org/2003/linkbase" 
          xmlns="http://www.w3.org/2001/XMLSchema" targetNamespace="http://www.xbrl.org/2003/linkbase" elementFormDefault="qualified">
        <element name = "referenceLink" substitutionGroup="xl:extended">
        <annotation>
        <documentation>
        reference extended link element definition
        </documentation>
        </annotation>
        <complexType>
        <complexContent>
        <restriction base="xl:extendedType">
        <choice minOccurs = "0" maxOccurs="unbounded">
        <element ref="xl:title"/>
        <element ref="link:documentation"/>
        <element ref="link:loc"/>
        <element ref="link:referenceArc"/>
        <element ref="link:reference"/>
        </choice>
        <anyAttribute namespace="http://www.w3.org/XML/1998/namespace" processContents="lax"/>
        </restriction>
        </complexContent>
        </complexType>
        </element>
        </schema>*/
        public static new RGS.Mapping.Model.QName QName => Namespaces.link + "referenceLink";

        public ReferenceLink(Linkbase parent, XElement xElement) : base(parent, xElement)
        { }

        public override void ProcessElement(XElement xElement)
        {
            if (xElement.Name == Loc.QName)
                _ = new ItemLoc(this, xElement);
            else if (xElement.Name == Reference.QName)
                _ = new Reference(this, xElement);
            else if (xElement.Name == ReferenceArc.QName)
                _ = new ReferenceArc(this, xElement);
            else
                base.ProcessElement(xElement);
        }
    }
}
