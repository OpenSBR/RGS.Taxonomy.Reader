using System.Xml.Linq;

namespace Xbrl.Discovery.Entities.referencepart
{
    public class Part : xml.Element
    {
        //public static new XName XName => Namespaces.referencepart + "Part";
        public static new RGS.Mapping.Model.QName QName => Namespaces.part + "part";

        public Part(xl.Resource parent, XElement xElement) : base(parent, xElement)
        { }
    }
}
