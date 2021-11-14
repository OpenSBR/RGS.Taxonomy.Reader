namespace Xbrl.Discovery.Entities.gen
{
    /*<schema xmlns:gen="http://xbrl.org/2008/generic" xmlns:xl="http://www.xbrl.org/2003/XLink" xmlns="http://www.w3.org/2001/XMLSchema" xmlns:link="http://www.xbrl.org/2003/linkbase" targetNamespace="http://xbrl.org/2008/generic" elementFormDefault="qualified">
    <annotation>
    <appinfo>
    <link:roleType roleURI = "http://www.xbrl.org/2008/role/link" id="standard-link-role">
    <link:usedOn>
    gen:link
    </link:usedOn>
    </link:roleType>
    </appinfo>
    </annotation>
    <import namespace="http://www.xbrl.org/2003/XLink" schemaLocation="http://www.xbrl.org/2003/xl-2003-12-31.xsd"/>
    <import namespace="http://www.xbrl.org/2003/linkbase" schemaLocation="http://www.xbrl.org/2003/xbrl-linkbase-2003-12-31.xsd"/>
    <element id = "xml-gen-arc" name="arc" substitutionGroup="xl:arc" type="gen:genericArcType"/>
    <complexType name = "genericArcType" >
    < complexContent >
    < extension base="xl:arcType">
    <attribute name = "id" type="ID"/>
    </extension>
    </complexContent>
    </complexType>
    <complexType name = "linkType" >
    < complexContent >
    < restriction base="xl:extendedType">
    <choice minOccurs = "0" maxOccurs="unbounded">
    <element ref="xl:title"/>
    <element ref="xl:documentation"/>
    <element ref="link:loc"/>
    <element ref="gen:arc"/>
    <element ref="xl:resource"/>
    </choice>
    <anyAttribute namespace="http://www.w3.org/XML/1998/namespace" processContents="lax"/>
    </restriction>
    </complexContent>
    </complexType>
    <complexType name = "linkTypeWithOpenAttrs" >
    < complexContent >
    < extension base="gen:linkType">
    <anyAttribute namespace="##other"/>
    </extension>
    </complexContent>
    </complexType>
    <element id = "xml-gen-link" name="link" substitutionGroup="xl:extended" type="gen:linkTypeWithOpenAttrs"/>
    </schema>*/
    public class Namespace
    {
        public const string Name = @"http://xbrl.org/2008/generic";
        public const string Prefix = "gen";
    }
}
