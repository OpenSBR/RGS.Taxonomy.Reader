using System;

namespace Xbrl.Discovery
{
    public class Enumeration : IComparable
    {
        public bool IsUnknown => Value == string.Empty;

        public virtual string Value { get; }

        protected Enumeration(string value)
        {
           Value = value;
        }

        public override string ToString() => Value;

        public override bool Equals(object obj)
        {
            Enumeration otherValue = obj as Enumeration;

            if (otherValue == null)
                return false;

            var typeMatches = GetType().Equals(obj.GetType());
            var valueMatches = Value.Equals(otherValue.Value);

            return typeMatches && valueMatches;
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        public int CompareTo(object other) => Value.CompareTo(((Enumeration)other).Value);
    }
}
