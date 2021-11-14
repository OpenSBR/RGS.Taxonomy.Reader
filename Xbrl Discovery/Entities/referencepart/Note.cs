using System.Xml.Linq;

namespace Xbrl.Discovery.Entities.referencepart
{
    public class Note : Part
    {
        public static new RGS.Mapping.Model.QName QName => Namespaces.referencepart + "Note";

        public Note(xl.Resource parent, XElement xElement) : base(parent, xElement)
        { }
    }
}
