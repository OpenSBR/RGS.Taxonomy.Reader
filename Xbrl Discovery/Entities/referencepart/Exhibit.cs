using System.Xml.Linq;

namespace Xbrl.Discovery.Entities.referencepart
{
    public class Exhibit : Part
    {
        public static new RGS.Mapping.Model.QName QName => Namespaces.referencepart + "Exhibit";

        public Exhibit(xl.Resource parent, XElement xElement) : base(parent, xElement)
        { }
    }
}
