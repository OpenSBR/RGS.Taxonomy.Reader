using System.Xml.Linq;

namespace Xbrl.Discovery.Entities.gen
{
    public class Arc : Arc<xl.Resource, xl.Resource>
    {
        public static new RGS.Mapping.Model.QName QName => Namespaces.gen + "arc";

        public Arc(Link parent, XElement xElement) : base(parent, xElement)
        { }
    }

    public class Arc<FromType, ToType> : xl.Arc<FromType, ToType>
        where FromType : xl.Resource
        where ToType : xl.Resource
    {
        public static new RGS.Mapping.Model.QName QName => Namespaces.gen + "arc";

        public Arc(Link parent, XElement xElement) : base(parent, xElement)
        { }
    }
}
