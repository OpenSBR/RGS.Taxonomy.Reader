using System.Xml.Linq;

namespace Xbrl.Discovery.Entities.rgs22
{
    public class TypedDimension : Dimension
    {
        public static new RGS.Mapping.Model.QName QName => Namespaces.rgs22 + "typedDimension";

        public TypedDimension(Primary parent, XElement xElement) : base(parent, xElement)
        { }
    }
}
