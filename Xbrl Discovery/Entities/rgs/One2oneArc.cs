using System.Xml.Linq;

namespace Xbrl.Discovery.Entities.rgs
{
    public class One2oneArc : DatapointArc
    {
        public static new RGS.Mapping.Model.QName QName => Namespaces.rgs + "one2oneArc";

        public One2oneArc(gen.Link parent, XElement xElement) : base(parent, xElement)
        { }
    }
}
