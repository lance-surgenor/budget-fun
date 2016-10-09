using System;

namespace Tegdub.Infrastructure
{
    /// <summary>
    /// Represents a denomination of time
    /// </summary>
    public class TimePeriodDenomination
        : Immutable<uint?, uint?>
    {
        public static TimePeriodDenomination Daily = new TimePeriodDenomination(1, null);
        public static TimePeriodDenomination Weekly = new TimePeriodDenomination(7, null);
        public static TimePeriodDenomination Fortnightly = new TimePeriodDenomination(14, null);
        public static TimePeriodDenomination Monthly = new TimePeriodDenomination(null, 1);
        public static TimePeriodDenomination Quarterly = new TimePeriodDenomination(null, 3);
        public static TimePeriodDenomination Yearly = new TimePeriodDenomination(null, 12);


        private uint? Days
        {
            get { return Value.Item1; }
        }
        private uint? Months
        {
            get { return Value.Item2; }
        }

        private TimePeriodDenomination(uint? days, uint? months)
            : base(days, months)
        { }

        public DateTime AddTo(DateTime referenceTime)
        {
            if (Days.HasValue)
                return referenceTime.AddDays(Days.Value);

            if (Months.HasValue)
                return referenceTime.AddMonths((int)Months.Value);

            throw new NotSupportedException("No supported time period denomination is specified that can be added to the reference time provided.");
        }

        #region Equality

        public override bool Equals(object obj)
        {
            return Equals(obj as TimePeriodDenomination);
        }

        public bool Equals(TimePeriodDenomination obj)
        {
            if (obj == null)
                return false;

            if (Days.HasValue)
                return Days.Equals(obj.Days);

            if (Months.HasValue)
                return Months.Equals(obj.Months);

            return false;
        }

        public override int GetHashCode()
        {
            return Days.GetHashCode()
                ^ Months.GetHashCode();
        }

        #endregion
    }

}