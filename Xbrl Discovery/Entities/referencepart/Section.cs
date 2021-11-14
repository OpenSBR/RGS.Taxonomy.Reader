using System.Xml.Linq;

namespace Xbrl.Discovery.Entities.referencepart
{
    public class Section : Part
    {
        public static new RGS.Mapping.Model.QName QName => Namespaces.referencepart + "Section";

        public Section(xl.Resource parent, XElement xElement) : base(parent, xElement)
        { }
    }
}
