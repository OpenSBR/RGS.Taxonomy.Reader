using System.Xml.Linq;

namespace Xbrl.Discovery.Entities.xml
{
    public abstract class Node : Entity<XNode>
    {
        public Node(Container parent, XNode xObject) : base(parent, xObject)
        {
            parent?.Nodes.Add(this);
        }
    }
    public abstract class Node<XObjectType> : Node
        where XObjectType : XNode
    {
        public new XObjectType XObject => (XObjectType)base.XObject;
        public Node(Container parent, XObjectType xObject) : base(parent, xObject)
        { }
    }
}
