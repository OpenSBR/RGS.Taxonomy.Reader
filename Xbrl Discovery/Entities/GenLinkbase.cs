using System.Xml.Linq;

namespace Xbrl.Discovery.Entities
{
    public class GenLinkbase : link.Linkbase
    {
        public GenLinkbase(xml.Document parent) : base(parent, string.Empty)
        { }

        public override void ProcessElement(XElement xElement)
        {
            if (xElement.Name == gen.Link.QName)
                _ = new gen.Link(this, xElement);
            else
                base.ProcessElement(xElement);
        }
    }
}
