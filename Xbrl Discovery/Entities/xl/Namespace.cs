﻿namespace Xbrl.Discovery.Entities.xl
{
    /*<schema
      xmlns = "http://www.w3.org/2001/XMLSchema" targetNamespace="http://www.xbrl.org/2003/XLink" elementFormDefault="qualified" attributeFormDefault="unqualified">
    <import namespace="http://www.w3.org/1999/xlink" schemaLocation="xlink-2003-12-31.xsd"/>
    <simpleType name = "nonEmptyURI" >
    < annotation >
    < documentation >
    A URI type with a minimum length of 1 character.Used on role and arcrole and href elements.
    </documentation>
    </annotation>
    <restriction base="anyURI">
    <minLength value = "1" />
    </ restriction >
    </ simpleType >
    < complexType name= "documentationType" >
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
    <annotation>
    <documentation>
    XBRL simple and extended link schema constructs
    </documentation>
    </annotation>
    <complexType name = "titleType" >
    < annotation >
    < documentation >
    Type for the abstract title element - used as a title element template.
    </documentation>
    </annotation>
    <complexContent>
    <restriction base="anyType">
    <attribute ref= "xlink:type" use= "required" fixed="title"/>
    </restriction>
    </complexContent>
    </complexType>
    <element name = "title" type= "xl:titleType" abstract="true">
    <annotation>
    <documentation>
    Generic title element for use in extended link documentation.Used on extended links, arcs, locators. See http://www.w3.org/TR/xlink/#title-element for details.
    </documentation>
    </annotation>
    </element>
    <complexType name = "locatorType" >
    < annotation >
    < documentation >
    Generic locator type.
    </documentation>
    </annotation>
    <complexContent>
    <restriction base="anyType">
    <sequence>
    <element ref= "xl:title" minOccurs= "0" maxOccurs= "unbounded" />
    </ sequence >
    < attribute ref= "xlink:type" use= "required" fixed="locator"/>
    <attribute ref= "xlink:href" use= "required" />
    < attribute ref= "xlink:label" use= "required" />
    < attribute ref= "xlink:role" use= "optional" />
    < attribute ref= "xlink:title" use= "optional" />
    </ restriction >
    </ complexContent >
    </ complexType >
    < element name= "locator" type= "xl:locatorType" abstract="true">
    <annotation>
    <documentation>
    Abstract locator element to be used as head of locator substitution group for all extended link locators in XBRL.
    </documentation>
    </annotation>
    </element>
    <simpleType name = "useEnum" >
    < annotation >
    < documentation >
    Enumerated values for the use attribute on extended link arcs.
    </documentation>
    </annotation>
    <restriction base="NMTOKEN">
    <enumeration value = "optional" />
    < enumeration value="prohibited"/>
    </restriction>
    </simpleType>
    <complexType name = "arcType" >
    < annotation >
    < documentation >
    basic extended link arc type - extended where necessary for specific arcs Extends the generic arc type by adding use, priority and order attributes.
    </documentation>
    </annotation>
    <complexContent>
    <restriction base="anyType">
    <sequence>
    <element ref="xl:title" minOccurs="0" maxOccurs="unbounded"/>
    </sequence>
    <attribute ref="xlink:type" use="required" fixed= "arc" />
    < attribute ref= "xlink:from" use = "required" />
    < attribute ref= "xlink:to" use = "required" />
    < attribute ref= "xlink:arcrole" use = "required" />
    < attribute ref= "xlink:title" use = "optional" />
    < attribute ref= "xlink:show" use = "optional" />
    < attribute ref= "xlink:actuate" use = "optional" />
    < attribute name = "order" type = "decimal" use = "optional" />
    < attribute name = "use" type = "xl:useEnum" use = "optional" />
    < attribute name = "priority" type = "integer" use = "optional" />
    < anyAttribute namespace="##other" processContents="lax"/>
    </restriction>
    </complexContent>
    </complexType>
    <element name = "arc" type="xl:arcType" abstract="true">
    <annotation>
    <documentation>
    Abstract element to use as head of arc element substitution group.
    </documentation>
    </annotation>
    </element>
    <complexType name = "resourceType" >
    < annotation >
    < documentation >
    Generic type for the resource type element
    </documentation>
    </annotation>
    <complexContent mixed = "true" >
    < restriction base="anyType">
    <attribute ref= "xlink:type" use= "required" fixed="resource"/>
    <attribute ref= "xlink:label" use= "required" />
    < attribute ref= "xlink:role" use= "optional" />
    < attribute ref= "xlink:title" use= "optional" />
    < attribute name= "id" type= "ID" use= "optional" />
    </ restriction >
    </ complexContent >
    </ complexType >
    < element name= "resource" type= "xl:resourceType" abstract="true">
    <annotation>
    <documentation>
    Abstract element to use as head of resource element substitution group.
    </documentation>
    </annotation>
    </element>
    <complexType name = "extendedType" >
    < annotation >
    < documentation >
    Generic extended link type
    </documentation>
    </annotation>
    <complexContent>
    <restriction base="anyType">
    <choice minOccurs = "0" maxOccurs= "unbounded" >
    < element ref= "xl:title" />
    < element ref= "xl:documentation" />
    < element ref= "xl:locator" />
    < element ref= "xl:arc" />
    < element ref= "xl:resource" />
    </ choice >
    < attribute ref= "xlink:type" use= "required" fixed="extended"/>
    <attribute ref= "xlink:role" use= "required" />
    < attribute ref= "xlink:title" use= "optional" />
    < attribute name= "id" type= "ID" use= "optional" />
    < anyAttribute namespace="http://www.w3.org/XML/1998/namespace" processContents="lax"/>
    </restriction>
    </complexContent>
    </complexType>
    <element name = "extended" type="xl:extendedType" abstract="true">
    <annotation>
    <documentation>
    Abstract extended link element at head of extended link substitution group.
     </documentation>
    </annotation>
    </element>
    <complexType name = "simpleType" >
    < annotation >
    < documentation >
    Type for the simple links defined in XBRL
    </documentation>
    </annotation>
    <complexContent>
    <restriction base="anyType">
    <attribute ref="xlink:type" use="required" fixed= "simple" />
    < attribute ref= "xlink:href" use = "required" />
    < attribute ref= "xlink:arcrole" use = "optional" />
    < attribute ref= "xlink:role" use = "optional" />
    < attribute ref= "xlink:title" use = "optional" />
    < attribute ref= "xlink:show" use = "optional" />
    < attribute ref= "xlink:actuate" use = "optional" />
    < anyAttribute namespace="http://www.w3.org/XML/1998/namespace" processContents="lax"/>
    </restriction>
    </complexContent>
    </complexType>
    <element name = "simple" type="xl:simpleType" abstract="true">
    <annotation>
    <documentation>
    The abstract element at the head of the simple link substitution group.
    </documentation>
    </annotation>
    </element>
    </schema>*/

    public enum UseEnum { optional, prohibited }

    public class Namespace
    {
        public const string Name = @"http://www.xbrl.org/2003/XLink";
        public const string Prefix = "xl";
    }
}
