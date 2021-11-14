using System.Xml.Linq;

namespace Xbrl.Discovery.Entities.xbrli
{
    public class Concept : xs.Element
    {
        public Concept(xs.Schema parent, XElement xElement) : base(parent, xElement)
        { }
    }
}
