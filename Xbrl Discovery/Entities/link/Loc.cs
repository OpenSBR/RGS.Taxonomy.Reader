using System;
using System.Collections.Generic;
using System.Xml.Linq;
using System.Xml.Schema;

namespace Xbrl.Discovery.Entities.link
{
    public class Loc : xl.Resource
    {
        /*<schema
          xmlns = "http://www.w3.org/2001/XMLSchema" targetNamespace="http://www.xbrl.org/2003/XLink" elementFormDefault="qualified" attributeFormDefault="unqualified">
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
        < attributeGroup ref= "xlink:locatorType" />
        < attribute ref= "xlink:href" use= "required" />
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
        </schema>
        <schema
          xmlns:link="http://www.xbrl.org/2003/linkbase" 
          xmlns="http://www.w3.org/2001/XMLSchema" targetNamespace="http://www.xbrl.org/2003/linkbase" elementFormDefault="qualified">
        <element name = "loc" type="xl:locatorType" substitutionGroup="xl:locator">
        <annotation>
        <documentation>
        Concrete locator element.The loc element is the XLink locator element for all extended links in XBRL.
        </documentation>
        </annotation>
        </element>
        </schema>*/
        public static new RGS.Mapping.Model.QName QName => Namespaces.link + "loc";

        public string HrefAttribute => Attribute(Namespaces.xlink + "href")?.Value;

        public List<xl.Title> Titles { get; } = new List<xl.Title>();

        protected Href _href;
        public override Href Href
        {
            get
            {
                if (_href == default)
                    _href = new Href(Dts, XObject, new Uri(Document.Filename));
                return _href;
            }
        }
        public xml.Element Element => Href.Element;

        public Loc(xl.ExtendedLink parent, XElement xElement) : base(parent, xElement)
        {
            Dts.DiscoverDocument(Dts.ResolveAbsoluteTargetLocation(HrefAttribute, Document.Filename));
        }

        public override void ProcessElement(XElement xElement)
        {
            if (xElement.Name == xl.Title.QName)
                Titles.Add(new xl.Title(this, xElement));
            else
                base.ProcessElement(xElement);
        }
    }
}