using System.Xml.Linq;

namespace Xbrl.Discovery.Entities.referencepart
{
    public class Number : Part
    {
        public static new RGS.Mapping.Model.QName QName => Namespaces.referencepart + "Number";

        public Number(xl.Resource parent, XElement xElement) : base(parent, xElement)
        { }
    }
}
