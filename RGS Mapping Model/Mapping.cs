namespace RGS.Mapping.Model
{
    public abstract class Mapping
    {
        public object? From { get; set; }
        public Datapoint? To { get; set; }
    }
}
