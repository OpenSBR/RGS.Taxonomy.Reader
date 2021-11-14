using System.Xml.Linq;

namespace Xbrl.Discovery.Entities.xml
{
    public abstract class Entity : Entities.Entity
    {
        public new Entity Parent => (Entity)base.Parent;

        public virtual XObject XObject { get; }

        public Entity(Container parent, XObject xObject) : base(parent)
        {
            XObject = xObject;
        }
    }
    public abstract class Entity<XObjectType> : Entity
        where XObjectType : XObject
    {
        public new XObjectType XObject => (XObjectType)base.XObject;

        public Entity(Container parent, XObjectType xObject) : base(parent, xObject)
        { }
    }
}
