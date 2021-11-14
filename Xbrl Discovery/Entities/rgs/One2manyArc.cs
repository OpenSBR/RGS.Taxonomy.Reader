using RGS.Mapping.Model;
using System.Xml.Linq;

namespace Xbrl.Discovery.Entities.rgs
{
    public class One2manyArc : DatapointArc
    {
        public static new QName QName => Namespaces.rgs + "one2manyArc";

        public One2manyArc(gen.Link parent, XElement xElement) : base(parent, xElement)
        { }
    }
}
