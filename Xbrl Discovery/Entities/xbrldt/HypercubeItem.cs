using System.Xml.Linq;

namespace Xbrl.Discovery.Entities.xbrldt
{
    public class HypercubeItem : xbrli.Item
    {
        //<xs:element name = "hypercubeItem" id="xbrldt_hypercubeItem" abstract="true" substitutionGroup="xbrli:item" type="xbrli:stringItemType" xbrli:periodType="duration"/>
        public static new RGS.Mapping.Model.QName QName => Namespaces.xbrldt + "hypercubeItem";

        public HypercubeItem(xs.Schema parent, XElement xElement) : base(parent, xElement)
        { }
    }
}
