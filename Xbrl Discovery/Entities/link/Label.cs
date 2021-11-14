using System.Xml.Linq;

namespace Xbrl.Discovery.Entities.link
{
    public class Label : xl.Resource
    {
        /*<schema
          xmlns:link="http://www.xbrl.org/2003/linkbase" 
          xmlns="http://www.w3.org/2001/XMLSchema" targetNamespace="http://www.xbrl.org/2003/linkbase" elementFormDefault="qualified">
        <element name = "label" substitutionGroup="xl:resource">
        <annotation>
        <documentation>
        Definition of the label resource element.
        </documentation>
        </annotation>
        <complexType mixed = "true" >
        < complexContent mixed= "true" >
        < extension base="xl:resourceType">
        <sequence>
        <any namespace="http://www.w3.org/1999/xhtml" processContents="skip" minOccurs="0" maxOccurs="unbounded"/>
        </sequence>
        <anyAttribute namespace="http://www.w3.org/XML/1998/namespace" processContents="lax"/>
        </extension>
        </complexContent>
        </complexType>
        </element>
        </schema>*/
        public static new RGS.Mapping.Model.QName QName => Namespaces.link + "label";

        public virtual string LangAttribute => Attribute(Namespaces.xml + "lang")?.Value;

        public Label(LabelLink parent, XElement xElement) : base(parent, xElement)
        { }
    }
}
