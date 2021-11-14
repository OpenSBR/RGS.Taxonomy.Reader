using System.Xml.Linq;

namespace Xbrl.Discovery.Entities.referencepart
{
    public class Sentence : Part
    {
        public static new RGS.Mapping.Model.QName QName => Namespaces.referencepart + "Sentence";

        public Sentence(xl.Resource parent, XElement xElement) : base(parent, xElement)
        { }
    }
}
