using System.Xml.Linq;

namespace Xbrl.Discovery.Entities.referencepart
{
    public class SubSection : Part
    {
        public static new RGS.Mapping.Model.QName QName => Namespaces.referencepart + "SubSection";

        public SubSection(xl.Resource parent, XElement xElement) : base(parent, xElement)
        { }
    }
}
