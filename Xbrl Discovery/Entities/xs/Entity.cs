using System.Xml.Linq;

namespace Xbrl.Discovery.Entities.xs
{
    public abstract class Entity : xml.Element
    {
        public new Schema RootElement => (Schema)base.RootElement;

        public Entity(xml.Document document) : base(document)
        { }
        public Entity(xml.Element parent, XElement xElement) : base(parent, xElement)
        { }

    }
}
