using System.Collections.Generic;
using System.Xml.Linq;

namespace Xbrl.Discovery.Entities.reference
{
    public class Reference : xl.Resource
    {
        /*<schema
          xmlns:link="http://www.xbrl.org/2003/linkbase" 
          xmlns="http://www.w3.org/2001/XMLSchema" targetNamespace="http://www.xbrl.org/2003/linkbase" elementFormDefault="qualified">
        <element name = "part" type="anySimpleType" abstract="true">
        <annotation>
        <documentation>
        Definition of the reference part element - for use in reference resources.
        </documentation>
        </annotation>
        </element>
        <element name = "reference" substitutionGroup= "xl:resource" >
        < annotation >
        < documentation >
        Definition of the reference resource element.
        </documentation>
        </annotation>
        <complexType mixed = "true" >
        < complexContent mixed= "true" >
        < extension base="xl:resourceType">
        <sequence>
        <element ref= "link:part" minOccurs= "0" maxOccurs= "unbounded" />
        </ sequence >
        </ extension >
        </ complexContent >
        </ complexType >
        </ element >
        </ schema >*/
        public static new RGS.Mapping.Model.QName QName => Namespaces.reference + "reference";

        public List<referencepart.Part> Parts { get; } = new List<referencepart.Part>();

        public Reference(gen.Link parent, XElement xElement) : base(parent, xElement)
        { }

        public override void ProcessElement(XElement xElement)
        {
            if (xElement.Name == referencepart.Publisher.QName)
                Parts.Add(new referencepart.Publisher(this, xElement));
            else if (xElement.Name == referencepart.Name.QName)
                Parts.Add(new referencepart.Name(this, xElement));
            else if (xElement.Name == referencepart.Number.QName)
                Parts.Add(new referencepart.Number(this, xElement));
            else if (xElement.Name == referencepart.IssueDate.QName)
                Parts.Add(new referencepart.IssueDate(this, xElement));
            else if (xElement.Name == referencepart.Chapter.QName)
                Parts.Add(new referencepart.Chapter(this, xElement));
            else if (xElement.Name == referencepart.Article.QName)
                Parts.Add(new referencepart.Article(this, xElement));
            else if (xElement.Name == referencepart.Note.QName)
                Parts.Add(new referencepart.Note(this, xElement));
            else if (xElement.Name == referencepart.Section.QName)
                Parts.Add(new referencepart.Section(this, xElement));
            else if (xElement.Name == referencepart.SubSection.QName)
                Parts.Add(new referencepart.SubSection(this, xElement));
            else if (xElement.Name == referencepart.Paragraph.QName)
                Parts.Add(new referencepart.Paragraph(this, xElement));
            else if (xElement.Name == referencepart.Subparagraph.QName)
                Parts.Add(new referencepart.Subparagraph(this, xElement));
            else if (xElement.Name == referencepart.Clause.QName)
                Parts.Add(new referencepart.Clause(this, xElement));
            else if (xElement.Name == referencepart.Subclause.QName)
                Parts.Add(new referencepart.Subclause(this, xElement));
            else if (xElement.Name == referencepart.Appendix.QName)
                Parts.Add(new referencepart.Appendix(this, xElement));
            else if (xElement.Name == referencepart.Example.QName)
                Parts.Add(new referencepart.Example(this, xElement));
            else if (xElement.Name == referencepart.Page.QName)
                Parts.Add(new referencepart.Page(this, xElement));
            else if (xElement.Name == referencepart.Exhibit.QName)
                Parts.Add(new referencepart.Exhibit(this, xElement));
            else if (xElement.Name == referencepart.Footnote.QName)
                Parts.Add(new referencepart.Footnote(this, xElement));
            else if (xElement.Name == referencepart.Sentence.QName)
                Parts.Add(new referencepart.Sentence(this, xElement));
            else if (xElement.Name == referencepart.Uri.QName)
                Parts.Add(new referencepart.Uri(this, xElement));
            else if (xElement.Name == referencepart.UriDate.QName)
                Parts.Add(new referencepart.UriDate(this, xElement));
            else
                base.ProcessElement(xElement);
        }
    }
}
