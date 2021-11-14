using System.Linq;
using System.Xml.Linq;

namespace Xbrl.Discovery.Entities.link
{
    //TODO
    /* Alleen in instance
     * public class FootnoteLink : ExtendedLink<FootnoteArc>
    {
        public static new RGS.Mapping.Model.QName QName => Namespaces.link + "footnoteLink";

        public FootnoteLink(Element parent, XElement xElement) : base(parent, xElement)
        {
            foreach (XElement xChildElement in from el in ChildElements(ConceptLoc.QName) select el)
                Resources.Add(new ConceptLoc(this, xChildElement));
            foreach (XElement xChildElement in from el in ChildElements(FootnoteArc.QName) select el)
                Arcs.Add(new FootnoteArc(this, xChildElement));
        }
    }*/
}
