using System.Collections.Generic;

namespace RGS.Mapping.Model
{
    public class Linkrole
    {
        public string Uri { get; set; }
        public List<Mapping> Mappings { get; } = new List<Mapping>();
    }
}
