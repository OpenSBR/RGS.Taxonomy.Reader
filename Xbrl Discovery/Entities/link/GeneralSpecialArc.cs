using System.Xml.Linq;

namespace Xbrl.Discovery.Entities.link
{
    public class GeneralSpecialArc : DefinitionArc<ItemLoc, ItemLoc>
    {
        public GeneralSpecialArc(DefinitionLink parent, XElement xElement) : base(parent, xElement)
        { }
    }
}
