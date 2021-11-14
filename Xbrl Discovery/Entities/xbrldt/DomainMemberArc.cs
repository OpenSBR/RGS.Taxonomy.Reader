using System.Xml.Linq;

namespace Xbrl.Discovery.Entities.xbrldt
{
    public class DomainMemberArc : link.DefinitionArc<ItemLoc, ItemLoc>
    {
        public DomainMemberArc(link.DefinitionLink parent, XElement xElement) : base(parent, xElement)
        { }
    }
}

