using System.Xml.Linq;

namespace Xbrl.Discovery.Entities.referencepart
{
    public class Example : Part
    {
        public static new RGS.Mapping.Model.QName QName => Namespaces.referencepart + "Example";

        public Example(xl.Resource parent, XElement xElement) : base(parent, xElement)
        { }
    }
}
