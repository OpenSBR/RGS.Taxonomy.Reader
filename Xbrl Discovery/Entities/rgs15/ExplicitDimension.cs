using System.Xml.Linq;

namespace Xbrl.Discovery.Entities.rgs15
{
    public class ExplicitDimension : Dimension
    {
        public static new RGS.Mapping.Model.QName QName => Namespaces.rgs15 + "explicitDimension";

        public virtual string MemberAttribute => Attribute("member")?.Value;
        protected xs.Element _member;
        public xs.Element Member
        {
            get
            {
                if (_member == default && MemberAttribute != default)
                    _member = Dts.GlobalXsElements[MemberAttribute];
                return _member;
            }
        }

        public ExplicitDimension(Primary parent, XElement xElement) : base(parent, xElement)
        { }
    }
}
