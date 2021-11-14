using System.Collections.Generic;
using System.Xml.Linq;

namespace Xbrl.Discovery.Entities.xml
{
    public abstract class Container : Node<XContainer>
    {
        public List<Node> Nodes { get; } = new List<Node>();

        public Container(Container parent, XContainer xObject) : base(parent, xObject)
        { }
    }
    public class Container<XObjectType> : Container
        where XObjectType : XContainer
    {
        public new XObjectType XObject => (XObjectType)base.XObject;
        public Container(Container parent, XObjectType xObject) : base(parent, xObject)
        { }
    }
}