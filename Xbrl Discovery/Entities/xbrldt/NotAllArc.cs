using System.Xml.Linq;

namespace Xbrl.Discovery.Entities.xbrldt
{
    public class NotAllArc : link.DefinitionArc<ItemLoc, HypercubeLoc>
    {
        public NotAllArc(link.DefinitionLink parent, XElement xElement) : base(parent, xElement)
        { }
    }
}
