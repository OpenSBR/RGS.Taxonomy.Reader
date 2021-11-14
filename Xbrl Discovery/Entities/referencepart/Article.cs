using System.Xml.Linq;

namespace Xbrl.Discovery.Entities.referencepart
{
    public class Article : Part
    {
        public static new RGS.Mapping.Model.QName QName => Namespaces.referencepart + "Article";

        public Article(xl.Resource parent, XElement xElement) : base(parent, xElement)
        { }
    }
}
