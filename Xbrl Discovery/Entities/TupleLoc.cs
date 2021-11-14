using System.Xml.Linq;

namespace Xbrl.Discovery.Entities
{
    public class TupleLoc : ConceptLoc
    {
        public TupleLoc(xl.ExtendedLink parent, XElement xElement) : base(parent, xElement)
        { }
    }
}
