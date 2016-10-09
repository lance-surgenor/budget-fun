using System;

namespace Tegdub.Infrastructure
{
    /// <summary>
    /// Represents a period of time
    /// </summary>
    public class TimePeriod
        : Immutable<TimePeriodDenomination, DateTime>
    {
        /// <summary>
        /// Denomination of time this period is counted in
        /// </summary>
        public TimePeriodDenomination Denomination
        {
            get { return Value.Item1; }
        }

        /// <summary>
        /// Time that this period starts
        /// </summary>
        public DateTime StartTime
        {
            get
            { return Value.Item2; }
        }

        /// <summary>
        /// Time that this period ends
        /// </summary>
        public DateTime EndTime
        {
            get
            {
                return Denomination.AddTo(StartTime);
            }
        }

        public TimePeriod(TimePeriodDenomination denomination, DateTime startTime)
            : base(denomination, startTime)
        { }

    }
}
