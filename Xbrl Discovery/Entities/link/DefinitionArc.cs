using System.Xml.Linq;

namespace Xbrl.Discovery.Entities.link
{
    public class DefinitionArc<FromType, ToType> : xl.Arc<FromType, ToType>
        where FromType : xl.Resource
        where ToType : xl.Resource
    {        
        /*<schema
          xmlns:link="http://www.xbrl.org/2003/linkbase" 
          xmlns="http://www.w3.org/2001/XMLSchema" targetNamespace="http://www.xbrl.org/2003/linkbase" elementFormDefault="qualified">
        <element name = "definitionArc" type="xl:arcType" substitutionGroup="xl:arc">
        <annotation>
        <documentation>
        Concrete arc for use in definition extended links.
        </documentation>
        </annotation>
        </element>
        </schema>*/
        public static new RGS.Mapping.Model.QName QName => Namespaces.link + "definitionArc";

        public DefinitionArc(DefinitionLink parent, XElement xElement) : base(parent, xElement)
        { }

        public virtual bool IsGeneralSpecial => ArcroleAttribute == Uris.GeneralSpecialArcrole;
        public virtual bool IsEssenceAlias => ArcroleAttribute == Uris.EssenceAliasArcrole;
        public virtual bool IsSimilarTuples => ArcroleAttribute == Uris.SimilarTuplesArcrole;
        public virtual bool IsRequiresElement => ArcroleAttribute == Uris.RequiresElementArcrole;
        public virtual bool IsHypercubeDimension => ArcroleAttribute == Uris.HypercubeDimensionArcrole;
        public virtual bool IsDimensionDomain => ArcroleAttribute == Uris.DimensionDomainArcrole;
        public virtual bool IsDomainMember => ArcroleAttribute == Uris.DomainMemberArcrole;
        public virtual bool IsAll => ArcroleAttribute == Uris.AllArcrole;
        public virtual bool IsNotAll => ArcroleAttribute == Uris.NotAllArcrole;
        public virtual bool IsDimensionDefault => ArcroleAttribute == Uris.DimensionDefaultArcrole;
    }
}
