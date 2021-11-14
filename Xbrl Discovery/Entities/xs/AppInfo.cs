using System.Collections.Generic;
using System.Xml.Linq;

namespace Xbrl.Discovery.Entities.xs
{
    public class Appinfo : Entity
    {
        public static new RGS.Mapping.Model.QName QName => Namespaces.xs + "appinfo";

        public List<link.LinkbaseRef> LinkbaseRefs = new List<link.LinkbaseRef>();
        public List<link.RoleType> RoleTypes = new List<link.RoleType>();
        public List<link.ArcroleType> ArcroleTypes = new List<link.ArcroleType>();

        public Appinfo(xml.Element parent, XElement xElement) : base(parent, xElement)
        { }

        public override void ProcessElement(XElement xElement)
        {
            if (xElement.Name == link.LinkbaseRef.QName)
                LinkbaseRefs.Add(new link.LinkbaseRef(this, xElement));
            else if (xElement.Name == link.RoleType.QName)
                RoleTypes.Add(new link.RoleType(this, xElement));
            else if (xElement.Name == link.ArcroleType.QName)
                ArcroleTypes.Add(new link.ArcroleType(this, xElement));
            else
                base.ProcessElement(xElement);
        }
    }
}