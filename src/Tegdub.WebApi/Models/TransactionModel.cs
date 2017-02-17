using System;
using System.Runtime.Serialization;
using Tegdub.Infrastructure;

namespace Tegdub.WebApi.Models
{
    [DataContract(Name = "Transaction")]
    public class TransactionModel
    {
        [DataMember(Name="AccountCode")]
        public string AccountCode { get; set; }

        [DataMember(Name="Time")]
        public DateTime Time { get; set; }

        [DataMember(Name= "Amount")]
        public MoneySerialisable Amount { get; set; }

        public static TransactionModel FromTransaction(Domain.Account.Transaction transaction)
        {
            return new TransactionModel()
            {
                AccountCode = transaction.Account.Code,
                Time = transaction.Time,
                Amount = MoneySerialisable.FromMoney(transaction.Amount)
            };
        }
    }
}