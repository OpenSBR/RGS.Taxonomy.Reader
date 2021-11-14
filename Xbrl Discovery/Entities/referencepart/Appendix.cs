using System.Xml.Linq;

namespace Xbrl.Discovery.Entities.referencepart
{
    public class Appendix : Part
    {
        public static new RGS.Mapping.Model.QName QName => Namespaces.referencepart + "Appendix";

        public Appendix(xl.Resource parent, XElement xElement) : base(parent, xElement)
        { }
    }
}
