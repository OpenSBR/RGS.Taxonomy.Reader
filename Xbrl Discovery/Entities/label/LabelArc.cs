using System.Xml.Linq;

namespace XbrlDiscovery.Entities.label
{
    public class LabelArc : gen.Arc<ConceptLoc, Label>
    {
        /*<schema
          xmlns:link="http://www.xbrl.org/2003/linkbase" 
          xmlns="http://www.w3.org/2001/XMLSchema" targetNamespace="http://www.xbrl.org/2003/linkbase" elementFormDefault="qualified">
        <element name = "labelArc" type="xl:arcType" substitutionGroup="xl:arc">
        <annotation>
        <documentation>
        Concrete arc for use in label extended links.
        </documentation>
        </annotation>
        </element>
        </schema>*/
        public static new XName XName => Namespaces.link + "labelArc";

        public LabelArc(LabelLink parent, XElement xElement) : base(parent, xElement)
        { }
    }
}
