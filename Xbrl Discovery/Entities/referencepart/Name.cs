using System.Xml.Linq;

namespace Xbrl.Discovery.Entities.referencepart
{
    public class Name : Part
    {
        public static new RGS.Mapping.Model.QName QName => Namespaces.referencepart + "Name";

        public Name(xl.Resource parent, XElement xElement) : base(parent, xElement)
        { }
    }
}
