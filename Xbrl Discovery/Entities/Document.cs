using System.Collections.Concurrent;
using System.Xml.Linq;

namespace Xbrl.Discovery.Entities
{
    public class Document : Entity
    {
        public xml.Element Root { get; set; }

        public XDocument XDocument { get; }
        public string Filename { get; }

        public ConcurrentDictionary<string, xml.Element> Elements { get; } = new ConcurrentDictionary<string, xml.Element>();

        public bool IsSchema => XDocument?.Root?.Name == xs.Schema.QName;
        public bool IsLinkbase => XDocument?.Root?.Name == link.Linkbase.QName;

        public Document(Dts dts, string filename) : base(dts)
        {
            XDocument = XDocument.Load(Filename = filename);
        }
    }
}
