using Newtonsoft.Json;
using System;
using System.Xml;
using System.Xml.Linq;

namespace RGS.Mapping.Model
{
    [JsonConverter(typeof(JsonConverter))]
    public class QName
    {
        public static XmlNamespaceManager XmlNamespaceManager { get; protected set; } = new XmlNamespaceManager(new NameTable());
        public static void ClearXmlNamespaceManager()
        {
            XmlNamespaceManager = new XmlNamespaceManager(new NameTable());
        }

        protected XName XName { get; }
        public QName(XName name)
        {
            XName = name;
        }

        public static implicit operator QName?(string name)
        {
            QName? result = default;
            if (name != default)
            {
                if (!name.Contains(':'))
                    result = (XName)name;
                else
                {
                    string[] names = name.Split(':');
                    result = XName.Get(names[1], XmlNamespaceManager.LookupNamespace(names[0]));
                }
            }
            return result;
        }
        public static implicit operator string(QName name) //=> name?.XName?.ToString();
        {
            string? result = default;
            if (name?.XName != default)
            {
                string prefix = XmlNamespaceManager.LookupPrefix(name.XName.NamespaceName);
                if (prefix == string.Empty)
                    result = name.XName.ToString();
                else
                    result = prefix + ":" + name.XName.LocalName;
            }
            return result;
        }
        public static implicit operator QName(XName name) => new QName(name);
        public static implicit operator XName?(QName name) => name?.XName;
        public static implicit operator QName(XmlQualifiedName name) => new QName(name == default || name.Name == string.Empty ? default : XName.Get(name.Name, name.Namespace));
        public static implicit operator XmlQualifiedName?(QName name) => name?.XName == default ? default : new XmlQualifiedName(name.XName.LocalName, name.XName.Namespace?.NamespaceName);

        public static bool operator ==(QName left, QName right) => left?.XName == right?.XName;
        public static bool operator ==(QName left, string right) => left == (QName)right;
        public static bool operator ==(string left, QName right) => (QName)left == right;
        public static bool operator ==(QName left, XName right) => left?.XName == right;
        public static bool operator ==(XName left, QName right) => left == right?.XName;
        public static bool operator ==(QName left, XmlQualifiedName right) => left == (QName)right;
        public static bool operator ==(XmlQualifiedName left, QName right) => (QName)left == right;
        public static bool operator !=(QName left, QName right) => left?.XName != right?.XName;
        public static bool operator !=(QName left, string right) => left != (QName)right;
        public static bool operator !=(string left, QName right) => (QName)left != right;
        public static bool operator !=(QName left, XName right) => left?.XName != right;
        public static bool operator !=(XName left, QName right) => left != right?.XName;
        public static bool operator !=(QName left, XmlQualifiedName right) => left != (QName)right;
        public static bool operator !=(XmlQualifiedName left, QName right) => (QName)left != right;

        public override bool Equals(object obj) => obj is QName && obj as QName == this;
        public override int GetHashCode() => base.GetHashCode();
        public override string ToString() => this;
        
        public class JsonConverter : JsonConverter<QName>
        {
            public override QName ReadJson(JsonReader reader, Type objectType, QName? existingValue, bool hasExistingValue, JsonSerializer serializer)
            {
                return new QName(reader.Value?.ToString());
            }
            public override void WriteJson(JsonWriter writer, QName? value, JsonSerializer serializer)
            {
                writer.WriteValue(value?.ToString());
            }
        }
    }
}
