using System.Xml.Linq;

namespace Xbrl.Discovery.Entities.link
{
    public class LabelLink : xl.ExtendedLink<LabelArc>
    {
        /*<schema
          xmlns:link="http://www.xbrl.org/2003/linkbase" 
          xmlns="http://www.w3.org/2001/XMLSchema" targetNamespace="http://www.xbrl.org/2003/linkbase" elementFormDefault="qualified">
        <element name = "labelLink" substitutionGroup="xl:extended">
        <annotation>
        <documentation>
        label extended link element definition
        </documentation>
        </annotation>
        <complexType>
        <complexContent>
        <restriction base="xl:extendedType">
        <choice minOccurs = "0" maxOccurs="unbounded">
        <element ref="xl:title"/>
        <element ref="link:documentation"/>
        <element ref="link:loc"/>
        <element ref="link:labelArc"/>
        <element ref="link:label"/>
        </choice>
        <anyAttribute namespace="http://www.w3.org/XML/1998/namespace" processContents="lax"/>
        </restriction>
        </complexContent>
        </complexType>
        </element>
        </schema>*/
        public static new RGS.Mapping.Model.QName QName => Namespaces.link + "labelLink";

        public LabelLink(Linkbase parent, XElement xElement) : base(parent, xElement)
        { }

        public override void ProcessElement(XElement xElement)
        {
            if (xElement.Name == Label.QName)
                _ = new Label(this, xElement);
            else if (xElement.Name == Loc.QName)
                _ = new ItemLoc(this, xElement);
            else if (xElement.Name == LabelArc.QName)
                _ = new LabelArc(this, xElement);
            else
                base.ProcessElement(xElement);
        }
    }
}
