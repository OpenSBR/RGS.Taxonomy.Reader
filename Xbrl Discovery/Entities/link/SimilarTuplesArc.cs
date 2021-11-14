using System.Xml.Linq;

namespace Xbrl.Discovery.Entities.link
{
    public class SimilarTuplesArc : DefinitionArc<TupleLoc, TupleLoc>
    {
        public SimilarTuplesArc(DefinitionLink parent, XElement xElement) : base(parent, xElement)
        { }
    }
}