using System.Collections.Generic;
using System.Linq;
using System.Xml.Linq;
using System.Xml.Schema;

namespace Xbrl.Discovery.Entities.xs
{
    public class Schema : Entity
    {
        public new static RGS.Mapping.Model.QName QName => Namespaces.xs + "schema";

        public new Schema RootElement => this;
        public new Entity ParentElement => default;

        public XmlSchema XmlSchema { get; set; }

        public List<Import> Imports = new List<Import>();
        public List<Include> Includes = new List<Include>();
        public List<Redefine> Redefines = new List<Redefine>();
        public Annotation Annotation;

        public string TargetNamespaceAttrbiute => Attribute("targetNamespace").Value;

        public Schema(xml.Document document) : base(document)
        { }
        public override void ProcessElement(XElement xElement)
        {
            if (xElement.Name == Import.QName)
                Imports.Add(new Import(this, xElement));
            else if (xElement.Name == Include.QName)
                Includes.Add(new Include(this, xElement));
            else if (xElement.Name == Redefine.QName)
                Redefines.Add(new Redefine(this, xElement));
            else if (xElement.Name == Annotation.QName)
                Annotation = new Annotation(this, xElement);
            else
                base.ProcessElement(xElement);
        }
    }
}
