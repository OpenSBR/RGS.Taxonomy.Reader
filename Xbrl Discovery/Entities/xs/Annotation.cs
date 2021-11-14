using System.Collections.Generic;
using System.Xml.Linq;

namespace Xbrl.Discovery.Entities.xs
{
    public class Annotation : Entity
    {
        public static new RGS.Mapping.Model.QName QName => Namespaces.xs + "annotation";

        public List<Appinfo> AppInfos = new List<Appinfo>();
        public List<link.Documentation> Documentations = new List<link.Documentation>();

        public Annotation(xml.Element parent, XElement xElement) : base(parent, xElement)
        { }

        public override void ProcessElement(XElement xElement)
        {
            if (xElement.Name == Appinfo.QName) 
                AppInfos.Add(new Appinfo(this, xElement));
            else if (xElement.Name == link.Documentation.QName)
                Documentations.Add(new link.Documentation(this, xElement));
            else
                base.ProcessElement(xElement);
        }
    }
}
