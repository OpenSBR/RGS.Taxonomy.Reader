using System.Xml.Linq;

namespace Xbrl.Discovery.Entities.xbrli
{
    public class Item : Concept
    {
        public static new RGS.Mapping.Model.QName QName => Namespaces.xbrli + "item";

        public virtual string AbstractAttribute => Attribute("abstract")?.Value;

        public Item(xs.Schema parent, XElement xElement) : base(parent, xElement)
        { }
    }
}
