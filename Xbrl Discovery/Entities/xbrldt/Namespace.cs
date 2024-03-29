﻿namespace Xbrl.Discovery.Entities.xbrldt
{
    /*<xs:schema
    xmlns = "http://www.xbrl.org/2003/linkbase"
    xmlns:xl="http://www.xbrl.org/2003/XLink" targetNamespace="http://xbrl.org/2005/xbrldt" elementFormDefault="qualified" attributeFormDefault="unqualified">
    <xs:annotation>
    <xs:appinfo>
    <arcroleType id = "hypercube-dimension" cyclesAllowed="none" arcroleURI="http://xbrl.org/int/dim/arcrole/hypercube-dimension">
    <definition>Source(a hypercube) contains the target(a dimension) among others.</definition>
    <usedOn>definitionArc</usedOn>
    </arcroleType>
    <arcroleType id = "dimension-domain" cyclesAllowed= "none" arcroleURI= "http://xbrl.org/int/dim/arcrole/dimension-domain" >
    < definition > Source(a dimension) has only the target (a domain) as its domain.</definition>
    <usedOn>definitionArc</usedOn>
    </arcroleType>
    <arcroleType id = "domain-member" cyclesAllowed= "undirected" arcroleURI= "http://xbrl.org/int/dim/arcrole/domain-member" >
    < definition > Source(a domain) contains the target (a member).</definition>
    <usedOn>definitionArc</usedOn>
    </arcroleType>
    <arcroleType id = "all" cyclesAllowed= "undirected" arcroleURI= "http://xbrl.org/int/dim/arcrole/all" >
    < definition > Source(a primary item declaration) requires a combination of dimension members of the target (hypercube) to appear in the context of the primary item.</definition>
    <usedOn>definitionArc</usedOn>
    </arcroleType>
    <arcroleType id = "notAll" cyclesAllowed= "undirected" arcroleURI= "http://xbrl.org/int/dim/arcrole/notAll" >
    < definition > Source(a primary item declaration) requires a combination of dimension members of the target (hypercube) not to appear in the context of the primary item.</definition>
    <usedOn>definitionArc</usedOn>
    </arcroleType>
    <arcroleType id = "dimension-default" cyclesAllowed= "none" arcroleURI= "http://xbrl.org/int/dim/arcrole/dimension-default" >
    < definition > Source(a dimension) declares that there is a default member that is the target of the arc (a member).</definition>
    <usedOn>definitionArc</usedOn>
    </arcroleType>
    </xs:appinfo>
    </xs:annotation>
    <xs:import namespace="http://www.xbrl.org/2003/instance" schemaLocation="http://www.xbrl.org/2003/xbrl-instance-2003-12-31.xsd"/>
    <xs:simpleType name = "contextElementType" >
    < xs:restriction base="xs:token">
    <xs:enumeration value = "segment" />
    < xs:enumeration value = "scenario" />
     </ xs:restriction>
    </xs:simpleType>
    <xs:attribute name = "contextElement" type="xbrldt:contextElementType"/>
    <xs:attribute name = "typedDomainRef" type="xs:anyURI"/>
    <xs:attribute name = "closed" type="xs:boolean" default="false"/>
    <xs:attribute name = "usable" type="xs:boolean" default="true"/>
    <xs:attribute name = "targetRole" type="xs:anyURI"/>
    <xs:element name = "hypercubeItem" id="xbrldt_hypercubeItem" abstract="true" substitutionGroup="xbrli:item" type="xbrli:stringItemType" xbrli:periodType="duration"/>
    <xs:element name = "dimensionItem" id="xbrldt_dimensionItem" abstract="true" substitutionGroup="xbrli:item" type="xbrli:stringItemType" xbrli:periodType="duration"/>
    </xs:schema>*/
    public class Namespace
    {
        public const string Name = @"http://xbrl.org/2005/xbrldt";
        public const string Prefix = "xbrldt";
    }
}
