using System.Xml.Linq;

namespace Xbrl.Discovery.Entities
{
    public class LabelLinkbase : link.Linkbase
    {
        public LabelLinkbase(xml.Document parent) : base(parent, @"http://www.xbrl.org/2003/role/labelLinkbaseRef") { }

        public override void ProcessElement(XElement xElement)
        {
            if (xElement.Name == link.LabelLink.QName)
                _ = new link.LabelLink(this, xElement);
            else
                base.ProcessElement(xElement);
        }
    }
}
