using System.Xml.Linq;

namespace Xbrl.Discovery.Entities
{
    public class ReferenceLinkbase : link.Linkbase
    {
        public ReferenceLinkbase(xml.Document parent) : base(parent, @"http://www.xbrl.org/2003/role/referenceLinkbaseRef")
        { }

        public override void ProcessElement(XElement xElement)
        {
            if (xElement.Name == link.ReferenceLink.QName)
                _ = new link.ReferenceLink(this, xElement);
            else
                base.ProcessElement(xElement);
        }
    }
}
