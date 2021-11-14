using System.Xml.Linq;

namespace Xbrl.Discovery.Entities.xbrldt
{
    public class DimensionLoc : ItemLoc
    {
        public DimensionLoc(link.DefinitionLink parent, XElement xElement) : base(parent, xElement)
        { }
    }
}
