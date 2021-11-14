using System.Xml.Linq;

namespace Xbrl.Discovery.Entities.rgs
{
    public class Datapoint : xl.Resource
    {
        public static new RGS.Mapping.Model.QName QName => Namespaces.rgs + "datapoint";

        public Entrypoint Entrypoint { get; protected set; }

        public Datapoint(gen.Link parent, XElement xElement) : base(parent, xElement)
        { }

        public override void ProcessElement(XElement xElement)
        {
            if (xElement.Name == Entrypoint.QName)
                Entrypoint = new Entrypoint(this, xElement);
            else
                base.ProcessElement(xElement);
        }
    }
}
