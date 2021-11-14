using System.Collections.Generic;

namespace RGS.Mapping.Model
{
    public class Report
    {
        public string RgsEntrypoint { get; set; }
        public string NtEntrypoint { get; set; }
        public List<Schema> Schemas { get; } = new List<Schema>();
        public List<Linkrole> Linkroles { get; } = new List<Linkrole>();
    }
}
