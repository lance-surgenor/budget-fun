using System.Runtime.Serialization;
using Tegdub.Infrastructure;

namespace Tegdub.WebApi.Models
{
    [DataContract(Name = "Fund")]
    public class FundModel
    {
        [DataMember(Name = "Name")]
        public string Name { get; set; }

        [DataMember(Name = "Balance")]
        public MoneySerialisable Balance { get; set; }

        public static FundModel FromFund(Domain.Fund fund)
        {
            return new FundModel()
            {
                Name = fund.Name,
                Balance = MoneySerialisable.FromMoney(fund.Balance)
            };
        }
    }
}
