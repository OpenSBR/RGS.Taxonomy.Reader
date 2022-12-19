using System.Xml.Linq;

namespace Xbrl.Discovery.Entities.rgs15
{
    public class Entrypoint : xml.Element
    {
        public static new RGS.Mapping.Model.QName QName => Namespaces.rgs15 + "entrypoint";

        public virtual string URIAttribute => Attribute("URI")?.Value;
        public Primary Primary { get; protected set; }

        public Entrypoint(Datapoint parent, XElement xElement) : base(parent, xElement)
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
