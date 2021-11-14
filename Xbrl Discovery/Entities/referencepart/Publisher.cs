using System.Xml.Linq;

namespace Xbrl.Discovery.Entities.referencepart
{
    public class Publisher : Part
    {
        public static new RGS.Mapping.Model.QName QName => Namespaces.referencepart + "Publisher";

        public Publisher(xl.Resource parent, XElement xElement) : base(parent, xElement)
        { }
    }
}
