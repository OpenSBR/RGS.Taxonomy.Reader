namespace Xbrl.Discovery.Entities.rgs15
{
    public class Container : Enumeration
    {
        public static Container Segment = new Container("segment");
        public static Container Scenario = new Container("scenario");

        public Container(string value) : base(value)
        { }

        public static implicit operator string(Container value)
        {
            return value.Value;
        }

        public static implicit operator Container(string value)
        {
            return new Container(value);
        }
    }
}
