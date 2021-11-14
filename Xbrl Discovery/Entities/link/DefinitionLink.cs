using System.Xml.Linq;

namespace Xbrl.Discovery.Entities.link
{
    public class DefinitionLink : xl.ExtendedLink<DefinitionArc<ItemLoc, ItemLoc>>
    {
        /*<schema
          xmlns:link="http://www.xbrl.org/2003/linkbase" 
          xmlns="http://www.w3.org/2001/XMLSchema" targetNamespace="http://www.xbrl.org/2003/linkbase" elementFormDefault="qualified">
        <element name = "definitionLink" substitutionGroup="xl:extended">
        <annotation>
        <documentation>
        definition extended link element definition
        </documentation>
        </annotation>
        <complexType>
        <complexContent>
        <restriction base="xl:extendedType">
        <choice minOccurs = "0" maxOccurs="unbounded">
        <element ref="xl:title"/>
        <element ref="link:documentation"/>
        <element ref="link:loc"/>
        <element ref="link:definitionArc"/>
        </choice>
        <anyAttribute namespace="http://www.w3.org/XML/1998/namespace" processContents="lax"/>
        </restriction>
        </complexContent>
        </complexType>
        </element>
        </schema>*/
        public static new RGS.Mapping.Model.QName QName => Namespaces.link + "definitionLink";

        public DefinitionLink(Linkbase parent, XElement xElement) : base(parent, xElement)
        { }

        public override void ProcessElement(XElement xElement)
        {
            if (xElement.Name == Loc.QName)
                _ = new ItemLoc(this, xElement);
            else if (xElement.Name == DefinitionArc<ItemLoc, ItemLoc>.QName)
            {
                //if (xElement.Attribute(Namespaces.xlink + "arcrole")?.Value == Uris.GeneralSpecialArcrole)
                //    Arcs.Add(new GeneralSpecialArc(this, xElement));
                //else if (xElement.Attribute(Namespaces.xlink + "arcrole")?.Value == Uris.EssenceAliasArcrole)
                //    Arcs.Add(new EssenseAliasArc(this, xElement));
                //else if (xElement.Attribute(Namespaces.xlink + "arcrole")?.Value == Uris.SimilarTuplesArcrole)
                //    //Arcs.Add(new SimilarTuplesArc(this, xElement));
                //else if (xElement.Attribute(Namespaces.xlink + "arcrole")?.Value == Uris.RequiresElementArcrole)
                //    //Arcs.Add(new RequiresElementArc(this, xElement));
                //else if (xElement.Attribute(Namespaces.xlink + "arcrole")?.Value == Uris.HypercubeDimensionArcrole)
                //    //Arcs.Add(new xbrldt.HypercubeDimensionArc(this, xElement));
                //else if (xElement.Attribute(Namespaces.xlink + "arcrole")?.Value == Uris.DimensionDomainArcrole)
                //    //Arcs.Add(new xbrldt.DimensionDomainArc(this, xElement));
                //else if (xElement.Attribute(Namespaces.xlink + "arcrole")?.Value == Uris.DomainMemberArcrole)
                //    //Arcs.Add(new xbrldt.DomainMemberArc(this, xElement));
                //else if (xElement.Attribute(Namespaces.xlink + "arcrole")?.Value == Uris.AllArcrole)
                //    //Arcs.Add(new xbrldt.AllArc(this, xElement));
                //else if (xElement.Attribute(Namespaces.xlink + "arcrole")?.Value == Uris.NotAllArcrole)
                //    //Arcs.Add(new xbrldt.NotAllArc(this, xElement));
                ////TODO
                ////else if (xElement.Attribute(Namespaces.xlink + "arcrole")?.Value == Uris.DimensionDefaultArcrole)
                ////    Arcs.Add();
                //else
                //    //Arcs.Add(new DefinitionArc<ConceptLoc<xbrli.Concept>, ConceptLoc<xbrli.Concept>>(this, xElement));
            }
            else
                base.ProcessElement(xElement);
        }
    }
}
