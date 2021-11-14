using System.Xml.Linq;

namespace Xbrl.Discovery.Entities.link
{
    public class ReferenceArc : xl.Arc<ConceptLoc, Reference>
    {
        /*<schema
          xmlns:link="http://www.xbrl.org/2003/linkbase" 
          xmlns="http://www.w3.org/2001/XMLSchema" targetNamespace="http://www.xbrl.org/2003/linkbase" elementFormDefault="qualified">
        <element name = "referenceArc" type="xl:arcType" substitutionGroup="xl:arc">
        <annotation>
        <documentation>
        Concrete arc for use in reference extended links.
        </documentation>
        </annotation>
        </element>
        </schema>*/
        public static new RGS.Mapping.Model.QName QName => Namespaces.link + "referenceArc";

        public ReferenceArc(ReferenceLink parent, XElement xElement) : base(parent, xElement)
        { }
    }
}
