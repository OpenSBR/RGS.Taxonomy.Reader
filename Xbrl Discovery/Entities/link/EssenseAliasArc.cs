using System.Xml.Linq;

namespace Xbrl.Discovery.Entities.link
{
    public class EssenseAliasArc : DefinitionArc<ItemLoc, ItemLoc>
    {
        public EssenseAliasArc(DefinitionLink parent, XElement xElement) : base(parent, xElement)
        { }
    }
}