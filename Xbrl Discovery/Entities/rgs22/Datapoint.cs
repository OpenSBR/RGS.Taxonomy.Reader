using System.Xml.Linq;

namespace Xbrl.Discovery.Entities.rgs22
{
    public class Datapoint : xl.Resource
    {
        public static new RGS.Mapping.Model.QName QName => Namespaces.rgs22 + "datapoint";

        public Primary Primary { get; protected set; }

        public Datapoint(gen.Link parent, XElement xElement) : base(parent, xElement)
        { }

        public override void ProcessElement(XElement xElement)
        {
            if (xElement.Name == Primary.QName)
                Primary = new Primary(this, xElement);
            else
                base.ProcessElement(xElement);
        }
    }
}
