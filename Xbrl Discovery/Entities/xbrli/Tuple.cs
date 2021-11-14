using System.Xml.Linq;

namespace Xbrl.Discovery.Entities.xbrli
{
    public class Tuple : Concept
    {
        public static new RGS.Mapping.Model.QName QName => Namespaces.xbrli + "tuple";

        public Tuple(xs.Schema parent, XElement xElement) : base(parent, xElement)
        { }
    }
}
