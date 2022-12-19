using System.Xml.Linq;

namespace Xbrl.Discovery.Entities.rgs15
{
    public class Many2oneArc : DatapointArc
    {
        public static new RGS.Mapping.Model.QName QName => Namespaces.rgs15 + "many2oneArc";

        public Many2oneArc(gen.Link parent, XElement xElement) : base(parent, xElement)
        { }
    }
}
