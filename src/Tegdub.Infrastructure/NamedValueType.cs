using System.Collections.Generic;

namespace Tegdub.Infrastructure
{
    /// <summary>
    /// Represents a value that can be used as though it is the underlying data type
    /// </summary>
    public class NamedValueType<T>
    {
        protected T Value { get; private set; }

        public NamedValueType(T value)
        {
            Value = value;
        }

        #region Equality

        public static bool operator ==(NamedValueType<T> lhs, NamedValueType<T> rhs)
        {
            if (lhs == null)
                return (rhs == null);

            return lhs.Equals(rhs);
        }

        public static bool operator !=(NamedValueType<T> lhs, NamedValueType<T> rhs)
        {
            return !(lhs == rhs);
        }

        /// <summary>
        /// Allows comparison between objects of type <see cref="NamedValueType{T}"/> and <typeparam name="T"/>
        /// </summary>
        public static bool operator ==(NamedValueType<T> lhs, T rhs)
        {
            if (lhs == null)
                return rhs == null;

            return lhs.Equals(rhs);
        }

        /// <summary>
        /// Allows comparison between objects of type <see cref="NamedValueType{T}"/> and <typeparam name="T"/>
        /// </summary>
        public static bool operator !=(NamedValueType<T> lhs, T rhs)
        {
            return !(lhs == rhs);
        }

        public override bool Equals(object obj)
        {
            if (obj == null)
                return false;

            T otherValue;
            if (obj.GetType() == typeof(T))
                otherValue = (T)obj;
            else if (obj.GetType() == GetType())
                otherValue = (obj as NamedValueType<T>).Value;
            else
            {
                // TODO: Determine if can implicitly cast other types and use this
                otherValue = (T)obj;
            }

            return EqualityComparer<T>.Default.Equals(Value, otherValue);
        }

        public override int GetHashCode()
        {
            return Value.GetHashCode();
        }

        #endregion

        #region Cast operators

        /// <summary>
        /// Allows usage as though using a value of type <typeparam name="T"/>
        /// </summary>
        public static implicit operator T(NamedValueType<T> obj)
        {
            if (obj == null)
                return default(T);

            return obj.Value;
        }

        #endregion
    }
}
