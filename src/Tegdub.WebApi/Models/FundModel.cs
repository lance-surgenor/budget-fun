﻿using System.Runtime.Serialization;
using Tegdub.Infrastructure;

namespace Tegdub.WebApi.Models
{
    [DataContract]
    public class FundModel
    {
        [DataMember(Name="Name")]
        public string Name { get; set; }

        [DataMember(Name="Balance")]
        public MoneySerialisable Balance { get; set; }

        public Domain.Fund ToFund()
        {
            return new Domain.Fund(Name, Balance.AsMoney());
        }

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
