namespace Xbrl.Discovery.Entities
{
    public abstract class Entity
    {
        public virtual Dts Dts => Parent is Dts ? (Dts)Parent : Parent?.Dts;
        public virtual Entity Parent { get; }

        public Entity(Entity parent)
        {
            Parent = parent;
        }
    }
}
