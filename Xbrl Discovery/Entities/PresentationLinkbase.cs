using System.Xml.Linq;

namespace Xbrl.Discovery.Entities
{
    public class PresentationLinkbase : link.Linkbase
    {
        public PresentationLinkbase(xml.Document parent) : base(parent, @"http://www.xbrl.org/2003/role/presentationLinkbaseRef")
        { }

        public override void ProcessElement(XElement xElement)
        {
            if (xElement.Name == link.PresentationLink.QName)
                _ = new link.PresentationLink(this, xElement);
            else
                base.ProcessElement(xElement);
        }
    }
}
