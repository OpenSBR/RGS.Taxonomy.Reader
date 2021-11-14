using System.Xml.Linq;

namespace Xbrl.Discovery.Entities.referencepart
{
    public class IssueDate : Part
    {
        public static new RGS.Mapping.Model.QName QName => Namespaces.referencepart + "IssueDate";

        public IssueDate(xl.Resource parent, XElement xElement) : base(parent, xElement)
        { }
    }
}
