﻿namespace Xbrl.Discovery.Entities.xlink
{
    /*<schema
      xmlns = "http://www.w3.org/2001/XMLSchema" targetNamespace="http://www.w3.org/1999/xlink" elementFormDefault="qualified" attributeFormDefault="qualified">
    <annotation>
    <documentation>
    XLink attribute specification
    </documentation>
    </annotation>
    <attribute name = "type" >
    < simpleType >
    < annotation >
    < documentation >
    Enumeration of values for the type attribute
    </documentation>
    </annotation>
    <restriction base="string">
    <enumeration value = "simple" />
    < enumeration value="extended"/>
    <enumeration value = "locator" />
    < enumeration value="arc"/>
    <enumeration value = "resource" />
    < enumeration value="title"/>
    </restriction>
    </simpleType>
    </attribute>
    <attribute name = "role" >
    < simpleType >
    < annotation >
    < documentation >
    A URI with a minimum length of 1 character.
    </documentation>
    </annotation>
    <restriction base="anyURI">
    <minLength value = "1" />
    </ restriction >
    </ simpleType >
    </ attribute >
    < attribute name="arcrole">
    <simpleType>
    <annotation>
    <documentation>
    A URI with a minimum length of 1 character.
    </documentation>
    </annotation>
    <restriction base="anyURI">
    <minLength value = "1" />
    </ restriction >
    </ simpleType >
    </ attribute >
    < attribute name="title" type="string"/>
    <attribute name = "show" >
    < simpleType >
    < annotation >
    < documentation >
    Enumeration of values for the show attribute
    </documentation>
    </annotation>
    <restriction base="string">
    <enumeration value = "new" />
    < enumeration value="replace"/>
    <enumeration value = "embed" />
    < enumeration value="other"/>
    <enumeration value = "none" />
    </ restriction >
    </ simpleType >
    </ attribute >
    < attribute name="actuate">
    <simpleType>
    <annotation>
    <documentation>
    Enumeration of values for the actuate attribute
    </documentation>
    </annotation>
    <restriction base="string">
    <enumeration value = "onLoad" />
    < enumeration value="onRequest"/>
    <enumeration value = "other" />
    < enumeration value="none"/>
    </restriction>
    </simpleType>
    </attribute>
    <attribute name = "label" type="NCName"/>
    <attribute name = "from" type="NCName"/>
    <attribute name = "to" type="NCName"/>
    <attribute name = "href" type="anyURI"/>
    </schema>*/

    public enum Type { simple, extended, locator, arc, resource, title }
    public enum Show { @new, replace, embed, other, none }
    public enum Actuate { onLoad, onRequest, other, none }

    public class Namespace
    {
        public const string Name = @"http://www.w3.org/1999/xlink";
        public const string Prefix = "xlink";
    }
}
