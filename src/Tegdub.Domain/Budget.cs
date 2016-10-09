using Tegdub.Infrastructure;

namespace Tegdub.Domain
{
    /// <summary>
    /// Represents a budget for a <see cref="Fund"/>
    /// </summary>
    public class Budget
        : Entity<ulong>
    {
        private readonly Fund _fund;

        /// <summary>
        /// The <see cref="Fund"/> that this budget applies to
        /// </summary>
        public Fund Fund
        {
            get { return _fund; }
        }

        /// <summary>
        /// Current target bugdet amount
        /// </summary>
        public Money Amount { get; private set; }

        public Budget(Fund fund, Money amount)
        {
            _fund = fund;
            Amount = amount;
        }



    }
}
