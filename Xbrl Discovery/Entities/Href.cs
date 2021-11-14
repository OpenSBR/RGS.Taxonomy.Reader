using System;
using System.Xml;
using System.Xml.Linq;

namespace Xbrl.Discovery.Entities
{
    public class Href
    {
        public Dts Dts { get; }

        public xml.Document Document => Dts.Documents[Uri.AbsoluteUri];

        public Uri Uri { get; }
        public string Id { get; }
        public string Value { get; }
        public string RoleURI { get; }

        private xml.Element _element;
        public xml.Element Element
        {
            get
            {
                if (_element == default)
                    _element = Resolve();
                return _element;
            }
        }

        public Href(Dts dts, XElement xElement)
            : this(dts, xElement.Attribute(Namespaces.xlink + "href")?.Value)
        {
        }

        public Href(Dts dts, XElement xElement, Uri baseUri)
            : this(dts, baseUri, GetUriFromHrefString(xElement.Attribute(Namespaces.xlink + "href")?.Value), GetIdFromHrefString(xElement.Attribute(Namespaces.xlink + "href")?.Value))
        {
        }

        public Href(Dts dts, string value)
            : this(dts, GetUriFromHrefString(value), GetIdFromHrefString(value))
        {
        }

        public Href(Dts dts, Uri baseUri, Uri relativeUri, string id)
            : this(dts, ResolveRelativeUri(baseUri, relativeUri), id)
        {
        }

        public Href(Dts dts, Uri absoluteUri, string id)
        {
            Dts = dts;
            Uri = absoluteUri;
            if (!Uri.IsAbsoluteUri)
                throw new Exception("Uri " + Uri + " is not absolute.");
            Id = id;
            Value = Uri.AbsoluteUri + "#" + Id;
        }

        public xml.Element Resolve() => Document.Elements[Value];

        public static Uri ResolveRelativeUri(Uri baseUri, Uri relativeUri)
        {
            Uri result = relativeUri;
            if (!result.IsAbsoluteUri)
                result = new XmlUrlResolver().ResolveUri(baseUri, relativeUri.OriginalString);
            return result;
        }

        public static Uri GetUriFromHrefString(string value)
        {
            Uri result = null;
            string[] valueParts = value.Split('#');
            result = new Uri(valueParts[0].Replace(@"%20", @" "), UriKind.RelativeOrAbsolute);
            return result;
        }

        public static string GetIdFromHrefString(string value)
        {
            string result = null;
            string[] valueParts = value.Split('#');
            if (valueParts.Length == 2)
                result = valueParts[1];
            else if (valueParts.Length > 2)
                throw new Exception("Invalid Href: " + value + ".");
            return result;
        }
    }
}
