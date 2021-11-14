using System.Collections.Generic;

namespace RGS.Mapping.Model
{
    public class Primary : Concept
    {
        public List<ExplicitDimension> ExplicitDimensions { get; } = new List<ExplicitDimension>();
        public List<TypedDimension> TypedDimensions { get; } = new List<TypedDimension>();   
    }
}
