using System.Xml.Linq;

namespace Xbrl.Discovery.Entities
{
    public class DefinitionLinkbase : link.Linkbase
    {
        public DefinitionLinkbase(xml.Document parent) : base(parent, @"http://www.xbrl.org/2003/role/definitionLinkbaseRef")
        { }

        public override void ProcessElement(XElement xElement)
        {
            if (xElement.Name == link.DefinitionLink.QName)
                _ = new link.DefinitionLink(this, xElement);
            else
                base.ProcessElement(xElement);
        }
    }
}
