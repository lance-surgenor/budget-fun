using System;
using Tegdub.Infrastructure;

namespace Tegdub.Domain
{
    /// <summary>
    /// Represents a pool of resource represented by <see cref="Money"/>
    /// </summary>
    public class Fund
        : Entity<ulong>
    {
        /// <summary>
        /// Friendly name of this fund
        /// </summary>
        public string Name { get; private set; }

        /// <summary>
        /// Current balance of this fund
        /// </summary>
        public Money Balance { get; private set; }

        public Fund(string name, Money balance)
        {
            Name = name;
            Balance = balance;
        }
    }
}
