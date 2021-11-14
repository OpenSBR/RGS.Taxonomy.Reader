using System.Xml.Linq;

namespace Xbrl.Discovery.Entities.referencepart
{
    public class UriDate : Part
    {
        public static new RGS.Mapping.Model.QName QName => Namespaces.referencepart + "UriDate";

        public UriDate(xl.Resource parent, XElement xElement) : base(parent, xElement)
        { }
    }
}
