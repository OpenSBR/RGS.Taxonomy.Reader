using RGS.Mapping.Model;
using System.Xml.Linq;

namespace Xbrl.Discovery.Entities.xs
{
    public class Element : Entity
    {
        public static new RGS.Mapping.Model.QName QName => Namespaces.xs + "element";

        public string NameAttribute => Attribute("name")?.Value;

        public virtual string SubstitutiongroupAttribute => Attribute("substitutiongroup")?.Value;

        public Element(xml.Element parent, XElement xElement) : base(parent, xElement)
        {
            if (NameAttribute != default)
                Dts.GlobalXsElements.TryAdd((QName)XName.Get(NameAttribute, RootElement.TargetNamespaceAttrbiute), this);
        }
    }
}
