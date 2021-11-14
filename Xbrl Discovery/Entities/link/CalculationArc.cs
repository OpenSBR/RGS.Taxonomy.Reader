using System.Xml.Linq;

namespace Xbrl.Discovery.Entities.link
{
    public class CalculationArc : xl.Arc<ItemLoc, ItemLoc>
    {
        /*<schema
          xmlns:link="http://www.xbrl.org/2003/linkbase" 
          xmlns="http://www.w3.org/2001/XMLSchema" targetNamespace="http://www.xbrl.org/2003/linkbase" elementFormDefault="qualified">
        <element name = "calculationArc" substitutionGroup="xl:arc">
        <complexType>
        <annotation>
        <documentation>
        Extension of the extended link arc type for calculation arcs.Adds a weight attribute to track weights on contributions to summations.
        </documentation>
        </annotation>
        <complexContent>
        <extension base="xl:arcType">
        <attribute name = "weight" type= "decimal" use= "required" />
        </ extension >
        </ complexContent >
        </ complexType >
        </ element >
        </ schema >*/
        public static new RGS.Mapping.Model.QName QName => Namespaces.link + "calculationArc";

        public string WeightAttribute => Attribute("weight")?.Value;

        public CalculationArc(CalculationLink parent, XElement xElement) : base(parent, xElement)
        { }
    }
}
