using System.Collections;
using System.Collections.Generic;
using System.Reflection;
using System.Xml.Linq;

namespace Xbrl.Discovery
{
    public class Namespaces : IEnumerable<KeyValuePair<string, XNamespace>>
    {
        public static readonly XNamespace xml = @"http://www.w3.org/XML/1998/namespace";
        public static readonly XNamespace xs = @"http://www.w3.org/2001/XMLSchema";
        public static readonly XNamespace xsi = @"http://www.w3.org/2001/XMLSchema-instance";
        public static readonly XNamespace xlink = @"http://www.w3.org/1999/xlink";
        public static readonly XNamespace xl = @"http://www.xbrl.org/2003/XLink";
        public static readonly XNamespace link = @"http://www.xbrl.org/2003/linkbase";
        public static readonly XNamespace xbrli = @"http://www.xbrl.org/2003/instance";
        public static readonly XNamespace referencepart = @"http://www.xbrl.org/2006/ref";
        public static readonly XNamespace part = @"http://www.xbrl.org/2003/linkbase";
        public static readonly XNamespace gen = @"http://xbrl.org/2008/generic";
        public static readonly XNamespace label = @"http://xbrl.org/2008/label";
        public static readonly XNamespace reference = @"http://xbrl.org/2008/reference";
        public static readonly XNamespace xhtml = @"http://www.w3.org/1999/xhtml";
        public static readonly XNamespace xbrldt = @"http://xbrl.org/2005/xbrldt";

        public static readonly XNamespace acf = @"http://xbrl.org/2010/filter/aspect-cover";
        public static readonly XNamespace bf = @"http://xbrl.org/2008/filter/boolean";
        public static readonly XNamespace cf = @"http://xbrl.org/2008/filter/concept";
        public static readonly XNamespace crf = @"http://xbrl.org/2010/filter/concept-relation";
        public static readonly XNamespace enums = @"http://xbrl.org/2014/extensible-enumerations";
        public static readonly XNamespace sev = @"http://xbrl.org/2016/assertion-severity";
        public static readonly XNamespace variable = @"http://xbrl.org/2008/variable";

        public static readonly XNamespace table = @"http://xbrl.org/2014/table";

        public static readonly XNamespace rgs = @"http://www.nltaxonomie.nl/rgs/2015/xbrl/rgs-syntax-extension";

        public static Dictionary<string, XNamespace> Items { get; } = new Dictionary<string, XNamespace>();

        static Namespaces()
        {
            foreach (FieldInfo fieldInfo in typeof(Namespaces).GetFields(BindingFlags.Static | BindingFlags.Public))
            {
                if (fieldInfo.FieldType==typeof(XNamespace))
                {
                    Items.Add(fieldInfo.Name, (XNamespace)fieldInfo.GetValue(default));
                }
            }
        }

        IEnumerator<KeyValuePair<string, XNamespace>> IEnumerable<KeyValuePair<string, XNamespace>>.GetEnumerator() => Items.GetEnumerator();
        IEnumerator IEnumerable.GetEnumerator() => Items.GetEnumerator();
    }
}
