namespace Xbrl.Discovery.Entities.reference
{
    public class Namespace
    {
        /*<schema 
        xmlns:gen="http://xbrl.org/2008/generic" 
        xmlns="http://www.w3.org/2001/XMLSchema" 
        xmlns:reference="http://xbrl.org/2008/reference" 
        xmlns:link="http://www.xbrl.org/2003/linkbase" 
        xmlns:xl="http://www.xbrl.org/2003/XLink" targetNamespace="http://xbrl.org/2008/reference" elementFormDefault="qualified">
        <annotation>
        <appinfo>
        <link:roleType roleURI="http://www.xbrl.org/2008/role/reference" id="standard-reference">
        <link:usedOn>
        reference:reference
        </link:usedOn>
        </link:roleType>
        <link:arcroleType id="element-reference" cyclesAllowed="undirected" arcroleURI="http://xbrl.org/arcrole/2008/element-reference">
        <link:definition>
        element has reference
        </link:definition>
        <link:usedOn>
        gen:arc
        </link:usedOn>
        </link:arcroleType>
        </appinfo>
        </annotation>
        <import namespace="http://www.xbrl.org/2003/XLink" schemaLocation="http://www.xbrl.org/2003/xl-2003-12-31.xsd"/>
        <import namespace="http://www.xbrl.org/2003/linkbase" schemaLocation="http://www.xbrl.org/2003/xbrl-linkbase-2003-12-31.xsd"/>
        <element id="xml-generic-reference" name="reference" substitutionGroup="xl:resource">
        <complexType mixed="true">
        <complexContent mixed="true">
        <extension base="xl:resourceType">
        <sequence>
        <element ref="link:part" minOccurs="0" maxOccurs="unbounded"/>
        </sequence>
        </extension>
        </complexContent>
        </complexType>
        </element>
        </schema>*/
        public const string Name = @"http://xbrl.org/2008/reference";
        public const string Prefix = "reference";
    }
}
