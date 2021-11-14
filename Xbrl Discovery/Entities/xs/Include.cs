using System.Xml.Linq;

namespace Xbrl.Discovery.Entities.xs
{
    public class Include : External
    {
        public static new RGS.Mapping.Model.QName QName => Namespaces.xs + "include";

        public Include(xml.Element parent, XElement xElement) : base(parent, xElement)
        { }
    }
}
