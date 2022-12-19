using System.Xml.Linq;

namespace Xbrl.Discovery.Entities.rgs15
{
    public abstract class DatapointArc : gen.Arc<Datapoint, Datapoint>
    {
        public DatapointArc(gen.Link parent, XElement xElement) : base(parent, xElement)
        { }
    }
}
