using System.Xml.Linq;

namespace Xbrl.Discovery.Entities.label
{
    public class Label : xl.Resource
    {
        public static new RGS.Mapping.Model.QName QName => Namespaces.label + "label";

        public virtual string LanguageAttribute => Attribute(Namespaces.xml + "language")?.Value;

        public Label(gen.Link parent, XElement xElement) : base(parent, xElement)
        { }
    }
}
