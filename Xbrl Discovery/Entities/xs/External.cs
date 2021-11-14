using System.Xml.Linq;

namespace Xbrl.Discovery.Entities.xs
{
    public abstract class External : Entity
    {
        public string SchemaLocationAttribute => Attribute("schemaLocation")?.Value;

        public External(xml.Element parent, XElement xElement) : base(parent, xElement)
        {
            Dts.DiscoverDocument(Dts.ResolveAbsoluteTargetLocation(SchemaLocationAttribute, Document.Filename));
        }
    }
}
