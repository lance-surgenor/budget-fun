using System;
using Tegdub.Infrastructure;

namespace Tegdub.Domain.Account
{
    /// <summary>
    /// Represents a monetary transaction against an <see cref="Account"/>
    /// </summary>
    public class Transaction
        : Entity<ulong>
    {
        /// <summary>
        /// The <see cref="Account"/> that this transaction is associated with
        /// </summary>
        public Account Account { get; private set; }

        /// <summary>
        /// Time this transaction took place
        /// </summary>
        public DateTime Time { get; private set; }

        /// <summary>
        /// Monetary amount this transaction was for
        /// </summary>
        public Money Amount { get; private set; }

        public Transaction(Account account, DateTime time, Money amount)
        {
            Account = account;
            Time = time;
            Amount = amount;
        }
    }
}