using System.Xml.Linq;

namespace Xbrl.Discovery.Entities.referencepart
{
    public class Paragraph : Part
    {
        public static new RGS.Mapping.Model.QName QName => Namespaces.referencepart + "Paragraph";

        public Paragraph(xl.Resource parent, XElement xElement) : base(parent, xElement)
        { }
    }
}
