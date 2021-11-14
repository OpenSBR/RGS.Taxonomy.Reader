using System.Xml.Linq;

namespace Xbrl.Discovery.Entities.link
{
    public class PresentationArc : xl.Arc<ItemLoc, ItemLoc>
    {
        /*<schema
          xmlns:link="http://www.xbrl.org/2003/linkbase" 
          xmlns="http://www.w3.org/2001/XMLSchema" targetNamespace="http://www.xbrl.org/2003/linkbase" elementFormDefault="qualified">
        <element name = "presentationArc" substitutionGroup="xl:arc">
        <complexType>
        <annotation>
        <documentation>
        Extension of the extended link arc type for presentation arcs.Adds a preferredLabel attribute that documents the role attribute value of preferred labels (as they occur in label extended links).
        </documentation>
        </annotation>
        <complexContent>
        <extension base="xl:arcType">
        <attribute name = "preferredLabel" use="optional">
        <simpleType>
        <restriction base="anyURI">
        <minLength value = "1" />
        </ restriction >
        </ simpleType >
        </ attribute >
        </ extension >
        </ complexContent >
        </ complexType >
        </ element >
        </ schema >*/
        public static new RGS.Mapping.Model.QName QName => Namespaces.link + "presentationArc";

        public string PreferredLabelAttribute => Attribute("preferredLabel")?.Value;

        public PresentationArc(PresentationLink parent, XElement xElement) : base(parent, xElement)
        { }
    }
}
