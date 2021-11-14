using System.Xml.Linq;

namespace Xbrl.Discovery.Entities.referencepart
{
    public class Pages : Part
    {
        public static new RGS.Mapping.Model.QName QName => Namespaces.link + "pages";

        public Pages(xl.Resource parent, XElement xElement) : base(parent, xElement)
        { }
    }
}
