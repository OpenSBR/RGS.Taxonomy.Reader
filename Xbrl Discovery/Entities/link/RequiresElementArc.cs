using System.Xml.Linq;

namespace Xbrl.Discovery.Entities.link
{
    public class RequiresElementArc : DefinitionArc<ConceptLoc, ConceptLoc>
    {
        public RequiresElementArc(DefinitionLink parent, XElement xElement) : base(parent, xElement)
        { }
    }
}