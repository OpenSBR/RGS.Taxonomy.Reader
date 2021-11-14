using System.Collections.Concurrent;
using System.Xml.Linq;

namespace Xbrl.Discovery.Entities.xml
{
    public class Document : Container<XDocument>
    {
        public Element Root { get; set; }
        public string Filename { get; }

        public ConcurrentDictionary<string, Element> Elements { get; } = new ConcurrentDictionary<string, Element>();

        public bool IsSchema => XObject?.Root?.Name == xs.Schema.QName;
        public bool IsLinkbase => XObject?.Root?.Name == link.Linkbase.QName;

        public Document(Dts parent, XDocument xObject) : base(parent, xObject)
        { }
        public Document(Dts dts, string filename) : this(dts, XDocument.Load(filename))
        {
            Filename = filename;
        }
    }
}
