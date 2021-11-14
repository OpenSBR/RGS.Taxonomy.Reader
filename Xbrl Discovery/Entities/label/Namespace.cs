namespace Xbrl.Discovery.Entities.gen.label
{
    public class Namespace
    {
        /*<schema
        xmlns:gen="http://xbrl.org/2008/generic" 
        xmlns="http://www.w3.org/2001/XMLSchema" 
        xmlns:label="http://xbrl.org/2008/label" 
        xmlns:link="http://www.xbrl.org/2003/linkbase" 
        xmlns:xl="http://www.xbrl.org/2003/XLink" targetNamespace="http://xbrl.org/2008/label" elementFormDefault="qualified">
        <annotation>
        <appinfo>
        <link:roleType roleURI = "http://www.xbrl.org/2008/role/label" id="standard-label">
        <link:usedOn>
        label:label
        </link:usedOn>
        </link:roleType>
        <link:roleType roleURI = "http://www.xbrl.org/2008/role/verboseLabel" id="verbose-label">
        <link:usedOn>
        label:label
        </link:usedOn>
        </link:roleType>
        <link:roleType roleURI = "http://www.xbrl.org/2008/role/terseLabel" id="terse-label">
        <link:usedOn>
        label:label
        </link:usedOn>
        </link:roleType>
        <link:roleType roleURI = "http://www.xbrl.org/2008/role/documentation" id="documentation">
        <link:usedOn>
        label:label
        </link:usedOn>
        </link:roleType>
        </appinfo>
        </annotation>
        <import namespace="http://www.xbrl.org/2003/XLink" schemaLocation="http://www.xbrl.org/2003/xl-2003-12-31.xsd"/>
        <annotation>
        <appinfo>
        <link:arcroleType id = "element-label" cyclesAllowed="undirected" arcroleURI="http://xbrl.org/arcrole/2008/element-label">
        <link:definition>
        element has label
        </link:definition>
        <link:usedOn>
        gen:arc
        </link:usedOn>
        </link:arcroleType>
        </appinfo>
        </annotation>
        <element id = "xml-generic-label" name="label" substitutionGroup="xl:resource">
        <complexType mixed = "true" >
        < complexContent mixed="true">
        <extension base="xl:resourceType">
        <sequence>
        <any namespace="http://www.w3.org/1999/xhtml" processContents="skip" minOccurs="0" maxOccurs="unbounded"/>
        </sequence>
        <anyAttribute namespace="http://www.w3.org/XML/1998/namespace" processContents="lax"/>
        </extension>
        </complexContent>
        </complexType>
        </element>
        </schema>*/
        public const string Name = @"http://xbrl.org/2008/label";
        public const string Prefix = "label";
    }
}
