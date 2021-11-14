using System.Xml.Linq;

namespace Xbrl.Discovery.Entities
{
    public class CalculationLinkbase : link.Linkbase
    {
        public CalculationLinkbase(xml.Document parent) : base(parent, @"http://www.xbrl.org/2003/role/calculationLinkbaseRef")
        { }

        public override void ProcessElement(XElement xElement)
        {
            if (xElement.Name == link.CalculationLink.QName)
                _ = new link.CalculationLink(this, xElement);
            else
                base.ProcessElement(xElement);
        }
    }
}
