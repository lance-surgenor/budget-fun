using System.Runtime.Serialization;

namespace Tegdub.Infrastructure
{
    [DataContract]
    public class MoneySerialisable
    {
        [DataMember(Name="Value")]
        public decimal Value { get; set; }

        public Money AsMoney()
        {
            return new Money(Value);
        }

        public static MoneySerialisable FromMoney(Money money)
        {
            return new MoneySerialisable()
            {
                Value = money.Value
            };
        }
    }

    /// <summary>
    /// Represents a value of resource
    /// </summary>
    /// <remarks>This class is intended to be immutable</remarks>
    public class Money
        : Immutable<decimal>
    {
        /// <summary>
        /// Value of this resource
        /// </summary>
        public new decimal Value
        {
            get { return base.Value; }
        }

        /// <summary>
        /// Initialises a <see cref="Money"/> representing a value of 0
        /// </summary>
        public Money()
            : this(0)
        { }

        /// <summary>
        /// Initialises a <see cref="Money"/> representing the value supplied
        /// </summary>
        public Money(decimal value)
            :base(value)
        {
        }
    }
}
