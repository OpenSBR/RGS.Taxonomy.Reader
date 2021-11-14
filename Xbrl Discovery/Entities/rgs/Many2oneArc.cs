using System.Xml.Linq;

namespace Xbrl.Discovery.Entities.rgs
{
    public class Many2oneArc : DatapointArc
    {
        public static new RGS.Mapping.Model.QName QName => Namespaces.rgs + "many2oneArc";

        public Many2oneArc(gen.Link parent, XElement xElement) : base(parent, xElement)
        { }
    }
}
