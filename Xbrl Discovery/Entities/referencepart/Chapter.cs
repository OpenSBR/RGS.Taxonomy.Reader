using System.Xml.Linq;

namespace Xbrl.Discovery.Entities.referencepart
{
    public class Chapter : Part
    {
        public static new RGS.Mapping.Model.QName QName => Namespaces.referencepart + "Chapter";

        public Chapter(xl.Resource parent, XElement xElement) : base(parent, xElement)
        { }
    }
}
