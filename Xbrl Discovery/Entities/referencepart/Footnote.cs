using System.Xml.Linq;

namespace Xbrl.Discovery.Entities.referencepart
{
    public class Footnote : Part
    {
        public static new RGS.Mapping.Model.QName QName => Namespaces.referencepart + "Footnote";

        public Footnote(xl.Resource parent, XElement xElement) : base(parent, xElement)
        { }
    }
}
