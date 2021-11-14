using System.Collections.Generic;
using System.Xml.Linq;

namespace Xbrl.Discovery.Entities.rgs
{
    public class Primary : xml.Element
    {
        public static new RGS.Mapping.Model.QName QName => Namespaces.rgs + "primary";

        public virtual string QNameAttribute => Attribute(Namespaces.rgs + "qname")?.Value;
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
        public List<ExplicitDimension> ExplicitDimensions { get; } = new List<ExplicitDimension>();
        public List<TypedDimension> TypedDimensions { get; } = new List<TypedDimension>();

        public Primary(Entrypoint parent, XElement xElement) : base(parent, xElement)
        { }

        public override void ProcessElement(XElement xElement)
        {
            if (xElement.Name == ExplicitDimension.QName)
                ExplicitDimensions.Add(new ExplicitDimension(this, xElement));
            if (xElement.Name == TypedDimension.QName)
                TypedDimensions.Add(new TypedDimension(this, xElement));
            else
                base.ProcessElement(xElement);
        }
    }
}
