using System.Xml.Linq;

namespace Xbrl.Discovery.Entities
{
    public class ConceptLoc : link.Loc
    {
        public ConceptLoc(xl.ExtendedLink parent, XElement xElement) : base(parent, xElement)
        { }
    }
}
