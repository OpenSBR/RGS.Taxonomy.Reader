using System.Xml.Linq;

namespace Xbrl.Discovery.Entities.xbrldt
{
    public class DimensionItem : xbrli.Item
    {
        public static new RGS.Mapping.Model.QName QName => Namespaces.xbrldt + "dimensionItem";

        public DimensionItem(xs.Schema parent, XElement xElement) : base(parent, xElement)
        { }
    }
}
