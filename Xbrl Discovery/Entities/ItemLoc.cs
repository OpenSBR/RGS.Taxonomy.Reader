using System.Xml.Linq;

namespace Xbrl.Discovery.Entities
{
    public class ItemLoc : ConceptLoc
    {
        public ItemLoc(xl.ExtendedLink parent, XElement xElement) : base(parent, xElement)
        { }
    }
}
