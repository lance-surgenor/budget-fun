using Tegdub.Infrastructure;

namespace Tegdub.Domain.Account
{
    /// <summary>
    /// Represents an actual resource account
    /// </summary>
    public class Account
        : Entity<ulong>
    {
        /// <summary>
        /// Code that identifies this account as unique
        /// </summary>
        public string Code { get; private set; }

        /// <summary>
        /// Friendly name of this account
        /// </summary>
        public string Name { get; private set; }

        public Account(string code, string name)
        {
            Code = code;
            Name = name;
        }
    }
}
