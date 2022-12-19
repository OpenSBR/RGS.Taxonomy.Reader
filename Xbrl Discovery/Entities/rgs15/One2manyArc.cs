using RGS.Mapping.Model;
using System.Xml.Linq;

namespace Xbrl.Discovery.Entities.rgs15
{
    public class One2manyArc : DatapointArc
    {
        public static new QName QName => Namespaces.rgs15 + "one2manyArc";

        public One2manyArc(gen.Link parent, XElement xElement) : base(parent, xElement)
        { }
    }
}
