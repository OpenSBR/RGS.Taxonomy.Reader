using System.Xml.Linq;

namespace Xbrl.Discovery.Entities.link
{
    public class UsedOn : xml.Element
    {
        /*<element name = "usedOn" type="QName">
        <annotation>
        <documentation>
        Definitionof the usedOn element - used to identify what elements may use a taxonomy defined role or arc role value.
        </documentation>
        </annotation>
        </element>*/
        public static new RGS.Mapping.Model.QName QName => Namespaces.link + "usedOn";


        public UsedOn(ArcroleType parent, XElement xElement) : base(parent, xElement)
        { }

        public UsedOn(RoleType parent, XElement xElement) : base(parent, xElement)
        { }
    }
}
