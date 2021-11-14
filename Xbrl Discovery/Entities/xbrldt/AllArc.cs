using System.Xml.Linq;

namespace Xbrl.Discovery.Entities.xbrldt
{
    public class AllArc : link.DefinitionArc<ItemLoc, HypercubeLoc>
    {
        public AllArc(link.DefinitionLink parent, XElement xElement) : base(parent, xElement)
        { }
    }
}
