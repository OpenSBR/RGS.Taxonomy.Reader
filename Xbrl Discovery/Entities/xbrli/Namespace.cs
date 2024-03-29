﻿namespace Xbrl.Discovery.Entities.xbrli
{
    /*<schema
  xmlns:link="http://www.xbrl.org/2003/linkbase"
  xmlns="http://www.w3.org/2001/XMLSchema" targetNamespace="http://www.xbrl.org/2003/instance" elementFormDefault="qualified">
<annotation>
<documentation>
Taxonomy schema for XBRL. This schema defines syntax relating to XBRL instances.
</documentation>
</annotation>
<import namespace="http://www.xbrl.org/2003/linkbase" schemaLocation="xbrl-linkbase-2003-12-31.xsd"/>
<annotation>
<documentation>
Define the attributes to be used on XBRL concept definitions
</documentation>
</annotation>
<attribute name="periodType">
<annotation>
<documentation>
The periodType attribute (restricting the period for XBRL items)
</documentation>
</annotation>
<simpleType>
<restriction base="token">
<enumeration value="instant"/>
<enumeration value="duration"/>
</restriction>
</simpleType>
</attribute>
<attribute name="balance">
<annotation>
<documentation>
The balance attribute (imposes calculation relationship restrictions)
</documentation>
</annotation>
<simpleType>
<restriction base="token">
<enumeration value="debit"/>
<enumeration value="credit"/>
</restriction>
</simpleType>
</attribute>
<annotation>
<documentation>
Define the simple types used as a base for for item types
</documentation>
</annotation>
<simpleType name="monetary">
<annotation>
<documentation>
the monetary type serves as the datatype for those financial concepts in a taxonomy which denote units in a currency. Instance items with this type must have a unit of measure from the ISO 4217 namespace of currencies.
</documentation>
</annotation>
<restriction base="decimal"/>
</simpleType>
<simpleType name="shares">
<annotation>
<documentation>
This datatype serves as the datatype for share based financial concepts.
</documentation>
</annotation>
<restriction base="decimal"/>
</simpleType>
<simpleType name="pure">
<annotation>
<documentation>
This datatype serves as the type for dimensionless numbers such as percentage change, growth rates, and other ratios where the numerator and denominator have the same units.
</documentation>
</annotation>
<restriction base="decimal"/>
</simpleType>
<simpleType name="nonZeroDecimal">
<annotation>
<documentation>
As the name implies this is a decimal value that can not take the value 0 - it is used as the type for the denominator of a fractionItemType.
</documentation>
</annotation>
<union>
<simpleType>
<restriction base="decimal">
<minExclusive value="0"/>
</restriction>
</simpleType>
<simpleType>
<restriction base="decimal">
<maxExclusive value="0"/>
</restriction>
</simpleType>
</union>
</simpleType>
<simpleType name="precisionType">
<annotation>
<documentation>
This type is used to specify the value of the precision attribute on numeric items. It consists of the union of nonNegativeInteger and "INF" (used to signify infinite precision or "exact value").
</documentation>
</annotation>
<union memberTypes="nonNegativeInteger">
<simpleType>
<restriction base="string">
<enumeration value="INF"/>
</restriction>
</simpleType>
</union>
</simpleType>
<simpleType name="decimalsType">
<annotation>
<documentation>
This type is used to specify the value of the decimals attribute on numeric items. It consists of the union of integer and "INF" (used to signify that a number is expressed to an infinite number of decimal places or "exact value").
</documentation>
</annotation>
<union memberTypes="integer">
<simpleType>
<restriction base="string">
<enumeration value="INF"/>
</restriction>
</simpleType>
</union>
</simpleType>
<attributeGroup name="factAttrs">
<annotation>
<documentation>
Attributes for all items and tuples.
</documentation>
</annotation>
<attribute name="id" type="ID" use="optional"/>
<anyAttribute namespace="##other" processContents="lax"/>
</attributeGroup>
<attributeGroup name="tupleAttrs">
<annotation>
<documentation>
Group of attributes for tuples.
</documentation>
</annotation>
<attributeGroup ref="xbrli:factAttrs"/>
</attributeGroup>
<attributeGroup name="itemAttrs">
<annotation>
<documentation>
Attributes for all items.
</documentation>
</annotation>
<attributeGroup ref="xbrli:factAttrs"/>
<attribute name="contextRef" type="IDREF" use="required"/>
</attributeGroup>
<attributeGroup name="essentialNumericItemAttrs">
<annotation>
<documentation>
Attributes for all numeric items (fractional and non-fractional).
</documentation>
</annotation>
<attributeGroup ref="xbrli:itemAttrs"/>
<attribute name="unitRef" type="IDREF" use="required"/>
</attributeGroup>
<attributeGroup name="numericItemAttrs">
<annotation>
<documentation>
Group of attributes for non-fractional numeric items
</documentation>
</annotation>
<attributeGroup ref="xbrli:essentialNumericItemAttrs"/>
<attribute name="precision" type="xbrli:precisionType" use="optional"/>
<attribute name="decimals" type="xbrli:decimalsType" use="optional"/>
</attributeGroup>
<attributeGroup name="nonNumericItemAttrs">
<annotation>
<documentation>
Group of attributes for non-numeric items
</documentation>
</annotation>
<attributeGroup ref="xbrli:itemAttrs"/>
</attributeGroup>
<annotation>
<documentation>
General numeric item types - for use on concept element definitions The following 3 numeric types are all based on the built-in data types of XML Schema.
</documentation>
</annotation>
<complexType name="decimalItemType" final="extension">
<simpleContent>
<extension base="decimal">
<attributeGroup ref="xbrli:numericItemAttrs"/>
</extension>
</simpleContent>
</complexType>
<complexType name="floatItemType" final="extension">
<simpleContent>
<extension base="float">
<attributeGroup ref="xbrli:numericItemAttrs"/>
</extension>
</simpleContent>
</complexType>
<complexType name="doubleItemType" final="extension">
<simpleContent>
<extension base="double">
<attributeGroup ref="xbrli:numericItemAttrs"/>
</extension>
</simpleContent>
</complexType>
<annotation>
<documentation>
XBRL domain numeric item types - for use on concept element definitions The following 4 numeric types are all types that have been identified as having particular relevance to the domain space addressed by XBRL and are hence included in addition to the built-in types from XML Schema.
</documentation>
</annotation>
<complexType name="monetaryItemType" final="extension">
<simpleContent>
<extension base="xbrli:monetary">
<attributeGroup ref="xbrli:numericItemAttrs"/>
</extension>
</simpleContent>
</complexType>
<complexType name="sharesItemType" final="extension">
<simpleContent>
<extension base="xbrli:shares">
<attributeGroup ref="xbrli:numericItemAttrs"/>
</extension>
</simpleContent>
</complexType>
<complexType name="pureItemType" final="extension">
<simpleContent>
<extension base="xbrli:pure">
<attributeGroup ref="xbrli:numericItemAttrs"/>
</extension>
</simpleContent>
</complexType>
<element name="numerator" type="decimal"/>
<element name="denominator" type="xbrli:nonZeroDecimal"/>
<complexType name="fractionItemType" final="extension">
<sequence>
<element ref="xbrli:numerator"/>
<element ref="xbrli:denominator"/>
</sequence>
<attributeGroup ref="xbrli:essentialNumericItemAttrs"/>
</complexType>
<annotation>
<documentation>
The following 13 numeric types are all based on the XML Schema built-in types that are derived by restriction from decimal.
</documentation>
</annotation>
<complexType name="integerItemType" final="extension">
<simpleContent>
<extension base="integer">
<attributeGroup ref="xbrli:numericItemAttrs"/>
</extension>
</simpleContent>
</complexType>
<complexType name="nonPositiveIntegerItemType" final="extension">
<simpleContent>
<extension base="nonPositiveInteger">
<attributeGroup ref="xbrli:numericItemAttrs"/>
</extension>
</simpleContent>
</complexType>
<complexType name="negativeIntegerItemType" final="extension">
<simpleContent>
<extension base="negativeInteger">
<attributeGroup ref="xbrli:numericItemAttrs"/>
</extension>
</simpleContent>
</complexType>
<complexType name="longItemType" final="extension">
<simpleContent>
<extension base="long">
<attributeGroup ref="xbrli:numericItemAttrs"/>
</extension>
</simpleContent>
</complexType>
<complexType name="intItemType" final="extension">
<simpleContent>
<extension base="int">
<attributeGroup ref="xbrli:numericItemAttrs"/>
</extension>
</simpleContent>
</complexType>
<complexType name="shortItemType" final="extension">
<simpleContent>
<extension base="short">
<attributeGroup ref="xbrli:numericItemAttrs"/>
</extension>
</simpleContent>
</complexType>
<complexType name="byteItemType" final="extension">
<simpleContent>
<extension base="byte">
<attributeGroup ref="xbrli:numericItemAttrs"/>
</extension>
</simpleContent>
</complexType>
<complexType name="nonNegativeIntegerItemType" final="extension">
<simpleContent>
<extension base="nonNegativeInteger">
<attributeGroup ref="xbrli:numericItemAttrs"/>
</extension>
</simpleContent>
</complexType>
<complexType name="unsignedLongItemType" final="extension">
<simpleContent>
<extension base="unsignedLong">
<attributeGroup ref="xbrli:numericItemAttrs"/>
</extension>
</simpleContent>
</complexType>
<complexType name="unsignedIntItemType" final="extension">
<simpleContent>
<extension base="unsignedInt">
<attributeGroup ref="xbrli:numericItemAttrs"/>
</extension>
</simpleContent>
</complexType>
<complexType name="unsignedShortItemType" final="extension">
<simpleContent>
<extension base="unsignedShort">
<attributeGroup ref="xbrli:numericItemAttrs"/>
</extension>
</simpleContent>
</complexType>
<complexType name="unsignedByteItemType" final="extension">
<simpleContent>
<extension base="unsignedByte">
<attributeGroup ref="xbrli:numericItemAttrs"/>
</extension>
</simpleContent>
</complexType>
<complexType name="positiveIntegerItemType" final="extension">
<simpleContent>
<extension base="positiveInteger">
<attributeGroup ref="xbrli:numericItemAttrs"/>
</extension>
</simpleContent>
</complexType>
<annotation>
<documentation>
The following 17 non-numeric types are all based on the primitive built-in data types of XML Schema.
</documentation>
</annotation>
<complexType name="stringItemType" final="extension">
<simpleContent>
<extension base="string">
<attributeGroup ref="xbrli:nonNumericItemAttrs"/>
</extension>
</simpleContent>
</complexType>
<complexType name="booleanItemType" final="extension">
<simpleContent>
<extension base="boolean">
<attributeGroup ref="xbrli:nonNumericItemAttrs"/>
</extension>
</simpleContent>
</complexType>
<complexType name="hexBinaryItemType" final="extension">
<simpleContent>
<extension base="hexBinary">
<attributeGroup ref="xbrli:nonNumericItemAttrs"/>
</extension>
</simpleContent>
</complexType>
<complexType name="base64BinaryItemType" final="extension">
<simpleContent>
<extension base="base64Binary">
<attributeGroup ref="xbrli:nonNumericItemAttrs"/>
</extension>
</simpleContent>
</complexType>
<complexType name="anyURIItemType" final="extension">
<simpleContent>
<extension base="anyURI">
<attributeGroup ref="xbrli:nonNumericItemAttrs"/>
</extension>
</simpleContent>
</complexType>
<complexType name="QNameItemType" final="extension">
<simpleContent>
<extension base="QName">
<attributeGroup ref="xbrli:nonNumericItemAttrs"/>
</extension>
</simpleContent>
</complexType>
<complexType name="durationItemType" final="extension">
<simpleContent>
<extension base="duration">
<attributeGroup ref="xbrli:nonNumericItemAttrs"/>
</extension>
</simpleContent>
</complexType>
<complexType name="dateTimeItemType" final="extension">
<simpleContent>
<extension base="xbrli:dateUnion">
<attributeGroup ref="xbrli:nonNumericItemAttrs"/>
</extension>
</simpleContent>
</complexType>
<complexType name="timeItemType" final="extension">
<simpleContent>
<extension base="time">
<attributeGroup ref="xbrli:nonNumericItemAttrs"/>
</extension>
</simpleContent>
</complexType>
<complexType name="dateItemType" final="extension">
<simpleContent>
<extension base="date">
<attributeGroup ref="xbrli:nonNumericItemAttrs"/>
</extension>
</simpleContent>
</complexType>
<complexType name="gYearMonthItemType" final="extension">
<simpleContent>
<extension base="gYearMonth">
<attributeGroup ref="xbrli:nonNumericItemAttrs"/>
</extension>
</simpleContent>
</complexType>
<complexType name="gYearItemType" final="extension">
<simpleContent>
<extension base="gYear">
<attributeGroup ref="xbrli:nonNumericItemAttrs"/>
</extension>
</simpleContent>
</complexType>
<complexType name="gMonthDayItemType" final="extension">
<simpleContent>
<extension base="gMonthDay">
<attributeGroup ref="xbrli:nonNumericItemAttrs"/>
</extension>
</simpleContent>
</complexType>
<complexType name="gDayItemType" final="extension">
<simpleContent>
<extension base="gDay">
<attributeGroup ref="xbrli:nonNumericItemAttrs"/>
</extension>
</simpleContent>
</complexType>
<complexType name="gMonthItemType" final="extension">
<simpleContent>
<extension base="gMonth">
<attributeGroup ref="xbrli:nonNumericItemAttrs"/>
</extension>
</simpleContent>
</complexType>
<annotation>
<documentation>
The following 5 non-numeric types are all based on the XML Schema built-in types that are derived by restriction and/or list from string.
</documentation>
</annotation>
<complexType name="normalizedStringItemType" final="extension">
<simpleContent>
<extension base="normalizedString">
<attributeGroup ref="xbrli:nonNumericItemAttrs"/>
</extension>
</simpleContent>
</complexType>
<complexType name="tokenItemType" final="extension">
<simpleContent>
<extension base="token">
<attributeGroup ref="xbrli:nonNumericItemAttrs"/>
</extension>
</simpleContent>
</complexType>
<complexType name="languageItemType" final="extension">
<simpleContent>
<extension base="language">
<attributeGroup ref="xbrli:nonNumericItemAttrs"/>
</extension>
</simpleContent>
</complexType>
<complexType name="NameItemType" final="extension">
<simpleContent>
<extension base="Name">
<attributeGroup ref="xbrli:nonNumericItemAttrs"/>
</extension>
</simpleContent>
</complexType>
<complexType name="NCNameItemType" final="extension">
<simpleContent>
<extension base="NCName">
<attributeGroup ref="xbrli:nonNumericItemAttrs"/>
</extension>
</simpleContent>
</complexType>
<annotation>
<documentation>
XML Schema components contributing to the context element
</documentation>
</annotation>
<element name="segment">
<complexType>
<sequence>
<any namespace="##other" processContents="lax" minOccurs="1" maxOccurs="unbounded"/>
</sequence>
</complexType>
</element>
<complexType name="contextEntityType">
<annotation>
<documentation>
The type for the entity element, used to describe the reporting entity. Note that the scheme attribute is required and cannot be empty.
</documentation>
</annotation>
<sequence>
<element name="identifier">
<complexType>
<simpleContent>
<extension base="token">
<attribute name="scheme" use="required">
<simpleType>
<restriction base="anyURI">
<minLength value="1"/>
</restriction>
</simpleType>
</attribute>
</extension>
</simpleContent>
</complexType>
</element>
<element ref="xbrli:segment" minOccurs="0"/>
</sequence>
</complexType>
<simpleType name="dateUnion">
<annotation>
<documentation>
The union of the date and dateTime simple types.
</documentation>
</annotation>
<union memberTypes="date dateTime"/>
</simpleType>
<complexType name="contextPeriodType">
<annotation>
<documentation>
The type for the period element, used to describe the reporting date info.
</documentation>
</annotation>
<choice>
<sequence>
<element name="startDate" type="xbrli:dateUnion"/>
<element name="endDate" type="xbrli:dateUnion"/>
</sequence>
<element name="instant" type="xbrli:dateUnion"/>
<element name="forever">
<complexType/>
</element>
</choice>
</complexType>
<complexType name="contextScenarioType">
<annotation>
<documentation>
Used for the scenario under which fact have been reported.
</documentation>
</annotation>
<sequence>
<any namespace="##other" processContents="lax" minOccurs="1" maxOccurs="unbounded"/>
</sequence>
</complexType>
<element name="context">
<annotation>
<documentation>
Used for an island of context to which facts can be related.
</documentation>
</annotation>
<complexType>
<sequence>
<element name="entity" type="xbrli:contextEntityType"/>
<element name="period" type="xbrli:contextPeriodType"/>
<element name="scenario" type="xbrli:contextScenarioType" minOccurs="0"/>
</sequence>
<attribute name="id" type="ID" use="required"/>
</complexType>
</element>
<annotation>
<documentation>
XML Schema components contributing to the unit element
</documentation>
</annotation>
<element name="measure" type="QName"/>
<complexType name="measuresType">
<annotation>
<documentation>
A collection of sibling measure elements
</documentation>
</annotation>
<sequence>
<element ref="xbrli:measure" minOccurs="1" maxOccurs="unbounded"/>
</sequence>
</complexType>
<element name="divide">
<annotation>
<documentation>
Element used to represent division in units
</documentation>
</annotation>
<complexType>
<sequence>
<element name="unitNumerator" type="xbrli:measuresType"/>
<element name="unitDenominator" type="xbrli:measuresType"/>
</sequence>
</complexType>
</element>
<element name="unit">
<annotation>
<documentation>
Element used to represent units information about numeric items
</documentation>
</annotation>
<complexType>
<choice>
<element ref="xbrli:measure" minOccurs="1" maxOccurs="unbounded"/>
<element ref="xbrli:divide"/>
</choice>
<attribute name="id" type="ID" use="required"/>
</complexType>
</element>
<annotation>
<documentation>
Elements to use for facts in instances
</documentation>
</annotation>
<element name="item" type="anyType" abstract="true">
<annotation>
<documentation>
Abstract item element used as head of item substitution group
</documentation>
</annotation>
</element>
<element name="tuple" type="anyType" abstract="true">
<annotation>
<documentation>
Abstract tuple element used as head of tuple substitution group
</documentation>
</annotation>
</element>
<element name="xbrl">
<annotation>
<documentation>
XBRL instance root element.
</documentation>
</annotation>
<complexType>
<sequence>
<element ref="link:schemaRef" minOccurs="1" maxOccurs="unbounded"/>
<element ref="link:linkbaseRef" minOccurs="0" maxOccurs="unbounded"/>
<element ref="link:roleRef" minOccurs="0" maxOccurs="unbounded"/>
<element ref="link:arcroleRef" minOccurs="0" maxOccurs="unbounded"/>
<choice minOccurs="0" maxOccurs="unbounded">
<element ref="xbrli:item"/>
<element ref="xbrli:tuple"/>
<element ref="xbrli:context"/>
<element ref="xbrli:unit"/>
<element ref="link:footnoteLink"/>
</choice>
</sequence>
<attribute name="id" type="ID" use="optional"/>
<anyAttribute namespace="http://www.w3.org/XML/1998/namespace" processContents="lax"/>
</complexType>
</element>
</schema>*/
    public class Namespace
    {
        public const string Name = @"http://www.xbrl.org/2003/instance";
        public const string Prefix = "xbrli";
    }
}
