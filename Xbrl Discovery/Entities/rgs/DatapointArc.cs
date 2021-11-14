using System.Xml.Linq;

namespace Xbrl.Discovery.Entities.rgs
{
    public abstract class DatapointArc : gen.Arc<Datapoint, Datapoint>
    {
        public DatapointArc(gen.Link parent, XElement xElement) : base(parent, xElement)
        { }
    }
}
