using System.Xml.Linq;

namespace Xbrl.Discovery.Entities.referencepart
{
    public class Page : Part
    {
        public static new RGS.Mapping.Model.QName QName => Namespaces.referencepart + "Page";

        public Page(xl.Resource parent, XElement xElement) : base(parent, xElement)
        { }
    }
}
