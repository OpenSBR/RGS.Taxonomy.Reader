using System.Xml.Linq;

namespace Xbrl.Discovery.Entities.referencepart
{
    public class Subclause : Part
    {
        public static new RGS.Mapping.Model.QName QName => Namespaces.referencepart + "Subclause";

        public Subclause(xl.Resource parent, XElement xElement) : base(parent, xElement)
        { }
    }
}
