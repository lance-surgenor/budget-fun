using System;
using System.Collections.Generic;

namespace Tegdub.Infrastructure
{
    public abstract class Immutable<T1, T2>
        : Immutable<Tuple<T1, T2>>
    {
        public Immutable(T1 value1, T2 value2)
            : base(new Tuple<T1, T2>(value1, value2))
        { }
    }

    /// <summary>
    /// Represents an immutable class, where the underlying value cannot change
    /// </summary>
    /// <typeparam name="T"></typeparam>
    [System.Diagnostics.DebuggerDisplay("{Value}")]
    public abstract class Immutable<T>
    // TODO: Enforce T to be of Immutable, or value types    
    {
        private readonly T _value;

        protected T Value
        {
            get { return _value; }
        }

        protected Immutable(T value)
        {
            _value = value;
        }

        #region Equality

        public static bool operator ==(Immutable<T> lhs, Immutable<T> rhs)
        {
            // Alternatively, we could check for and treat null == null here
            if (lhs == null)
                return false;
            if (rhs == null)
                return false;

            return lhs.Equals(rhs);
        }

        public static bool operator !=(Immutable<T> lhs, Immutable<T> rhs)
        {
            return !(lhs == rhs);
        }

        public override bool Equals(object obj)
        {
            if (obj == null)
                return false;

            // Different types are semantically different, even if underlying value is the same
            if (obj.GetType() != GetType())
                return false;

            var otherValue = (obj as Immutable<T>).Value;
            return EqualityComparer<T>.Default.Equals(Value, otherValue);
        }

        public override int GetHashCode()
        {
            return Value.GetHashCode();
        }

        #endregion

    }
}
