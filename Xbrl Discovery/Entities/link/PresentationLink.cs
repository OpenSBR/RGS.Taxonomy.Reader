using System.Xml.Linq;

namespace Xbrl.Discovery.Entities.link
{
    public class PresentationLink : xl.ExtendedLink<PresentationArc>
    {
        /*<schema
          xmlns:link="http://www.xbrl.org/2003/linkbase" 
          xmlns="http://www.w3.org/2001/XMLSchema" targetNamespace="http://www.xbrl.org/2003/linkbase" elementFormDefault="qualified">
        <element name = "presentationLink" substitutionGroup="xl:extended">
        <annotation>
        <documentation>
        presentation extended link element definition.
        </documentation>
        </annotation>
        <complexType>
        <complexContent>
        <restriction base="xl:extendedType">
        <choice minOccurs = "0" maxOccurs="unbounded">
        <element ref="xl:title"/>
        <element ref="link:documentation"/>
        <element ref="link:loc"/>
        <element ref="link:presentationArc"/>
        </choice>
        <anyAttribute namespace="http://www.w3.org/XML/1998/namespace" processContents="lax"/>
        </restriction>
        </complexContent>
        </complexType>
        </element>
        </schema>*/
        public static new RGS.Mapping.Model.QName QName => Namespaces.link + "presentationLink";

        public PresentationLink(Linkbase parent, XElement xElement) : base(parent, xElement)
        { }

        public override void ProcessElement(XElement xElement)
        {
            if (xElement.Name == Loc.QName)
                _ = new ItemLoc(this, xElement);
            else if (xElement.Name == PresentationArc.QName)
                _ = new PresentationArc(this, xElement);
            else
                base.ProcessElement(xElement);
        }
    }
}
