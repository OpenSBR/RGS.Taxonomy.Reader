using System.Xml.Linq;

namespace Xbrl.Discovery.Entities.xs
{
    public class Redefine : External
    {
        public static new RGS.Mapping.Model.QName QName => Namespaces.xs + "redefine";

        public Redefine(xml.Element parent, XElement xElement) : base(parent, xElement)
        { }
    }
}
