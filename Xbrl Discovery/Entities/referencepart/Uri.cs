using System.Xml.Linq;

namespace Xbrl.Discovery.Entities.referencepart
{
    public class Uri : Part
    {
        public static new RGS.Mapping.Model.QName QName => Namespaces.referencepart + "Uri";

        public Uri(xl.Resource parent, XElement xElement) : base(parent, xElement)
        { }
    }
}
