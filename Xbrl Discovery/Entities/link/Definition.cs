using System.Xml.Linq;

namespace Xbrl.Discovery.Entities.link
{
    public class Definition : xml.Element
    {
        /*<element name="definition" type="string">
        <annotation>
        <documentation>
        The element to use for human-readable definition of custom roles and arc roles.
        </documentation>
        </annotation>
        </element>*/
        public static new RGS.Mapping.Model.QName QName => Namespaces.link + "definition";

        public Definition(ArcroleType parent, XElement xElement) : base(parent, xElement)
        { }

        public Definition(RoleType parent, XElement xElement) : base(parent, xElement)
        { }
    }
}
