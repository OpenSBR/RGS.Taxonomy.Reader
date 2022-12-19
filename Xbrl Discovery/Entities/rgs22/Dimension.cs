using System.Xml.Linq;

namespace Xbrl.Discovery.Entities.rgs22
{
    public abstract class Dimension : xml.Element
    {
        public virtual string QNameAttribute => Attribute(Namespaces.rgs22 + "qname")?.Value;
        protected xs.Element _concept;
        public xs.Element Concept
        {
            get
            {
                if (_concept == default && QNameAttribute != default)
                    _concept = Dts.GlobalXsElements[QNameAttribute];
                return _concept;
            }
        }

        public Dimension(Primary parent, XElement xElement) : base(parent, xElement)
        { }
    }
}
