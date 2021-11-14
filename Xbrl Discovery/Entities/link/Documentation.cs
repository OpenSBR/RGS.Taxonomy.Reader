using System.Xml.Linq;

namespace Xbrl.Discovery.Entities.link
{
    public class Documentation : xml.Element
    {
        /*<schema
          xmlns = "http://www.w3.org/2001/XMLSchema" targetNamespace="http://www.xbrl.org/2003/XLink" elementFormDefault="qualified" attributeFormDefault="unqualified">
        <complexType name = "documentationType" >
        < annotation >
        < documentation >
        Element type to use for documentation of extended links and linkbases.
        </documentation>
        </annotation>
        <simpleContent>
        <extension base="string">
        <anyAttribute namespace="##other" processContents="lax"/>
        </extension>
        </simpleContent>
        </complexType>
        <element name = "documentation" type="xl:documentationType" abstract="true">
        <annotation>
        <documentation>
        Abstract element to use for documentation of extended links and linkbases.
        </documentation>
        </annotation>
        </element>
        </schema>
        <schema
          xmlns:link= "http://www.xbrl.org/2003/linkbase"
          xmlns= "http://www.w3.org/2001/XMLSchema" targetNamespace= "http://www.xbrl.org/2003/linkbase" elementFormDefault= "qualified" >
        < element name= "documentation" type= "xl:documentationType" substitutionGroup= "xl:documentation" >
        < annotation >
        < documentation >
        Concrete element to use for documentation of extended links and linkbases.
        </documentation>
        </annotation>
        </element>
        </schema>*/
        public static new RGS.Mapping.Model.QName QName => Namespaces.link + "documentation";

        public Documentation(xs.Annotation parent, XElement xElement) : base(parent, xElement)
        { }

        public Documentation(Linkbase parent, XElement xElement) : base(parent, xElement)
        { }

        public Documentation(xl.ExtendedLink parent, XElement xElement) : base(parent, xElement)
        { }
    }
}
