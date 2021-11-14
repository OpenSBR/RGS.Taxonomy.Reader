using System.Xml.Linq;

namespace Xbrl.Discovery.Entities.xbrldt
{
    public class HypercubeLoc : ItemLoc
    {
        public HypercubeLoc(link.DefinitionLink parent, XElement xElement) : base(parent, xElement)
        { }
    }
}
