using System.Xml.Linq;

namespace Xbrl.Discovery.Entities.gen
{
    public class Link : xl.ExtendedLink<Arc>
    {
        public static new RGS.Mapping.Model.QName QName => Namespaces.gen + "link";

        public Link(link.Linkbase parent, XElement xElement) : base(parent, xElement)
        { }

        public override void ProcessElement(XElement xElement)
        {
            if (xElement.Name == xl.Resource.QName)
                _ = new xl.Resource(this, xElement);
            else if (xElement.Name == link.Loc.QName)
                _ = new link.Loc(this, xElement);
            else if (xElement.Name == Arc.QName)
                _ = new Arc(this, xElement);
            else if (xElement.Name == Entities.label.Label.QName)
                Labels.Add(new Entities.label.Label(this, xElement));
            else
                base.ProcessElement(xElement);
        }
    }
}
