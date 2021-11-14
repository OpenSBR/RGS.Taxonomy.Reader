using System.Xml.Linq;

namespace Xbrl.Discovery.Entities.referencepart
{
    public class Clause : Part
    {
        public static new RGS.Mapping.Model.QName QName => Namespaces.referencepart + "Clause";

        public Clause(xl.Resource parent, XElement xElement) : base(parent, xElement)
        { }
    }
}
