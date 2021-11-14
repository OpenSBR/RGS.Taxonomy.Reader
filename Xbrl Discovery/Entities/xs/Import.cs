using System.Xml.Linq;

namespace Xbrl.Discovery.Entities.xs
{
    public class Import : External
    {
        public static new RGS.Mapping.Model.QName QName => Namespaces.xs + "import";

        public Import(xml.Element parent, XElement xElement) : base(parent, xElement)
        { }
    }
}
