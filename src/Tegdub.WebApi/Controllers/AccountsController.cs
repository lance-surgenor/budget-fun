using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;
using Tegdub.Infrastructure;
using Tegdub.WebApi.Models;

namespace Tegdub.WebApi.Controllers
{
    public class AccountsController
        : ApiController
    {
        public IEnumerable<AccountModel> Get()
        {
            return new[]
            {
                new AccountModel()
                {
                    Name = "Eftpos",
                    Code = "eft"
                },
                new AccountModel()
                {
                    Name = "Credit",
                    Code = "credit"
                }
            };
        }

        [ActionName("default")]
        public AccountModel Get(string code)
        {
            return Get().FirstOrDefault(a => a.Code == code);
        }

        [ActionName("transactions")]
        public IEnumerable<TransactionModel> GetTransactions(string code)
        {
            var account = Get(code);
            if (account == null)
                return null;
            var transactions = CreateMockData(account.Code);
            return transactions;
        }

        //[Route("api/accounts/{accountId}/transactions/{id}")]
        //public TransactionModel GetTransaction(string accountName, int id)
        //{
        //    var transactions = CreateMockData(accountName);
        //    return transactions.Skip(id).FirstOrDefault();
        //}

        #region Mock Data

        private IEnumerable<TransactionModel> CreateMockData(string accountCode)
        {
            switch (accountCode.ToUpperInvariant())
            {
                case "EFT":
                    return new[]
                    {
                        CreateMockData(accountCode, 1, 123.45),
                        CreateMockData(accountCode, 2, 34.56),
                        CreateMockData(accountCode, 3, 56.78),
                        CreateMockData(accountCode, 5, 89.01)
                    };
                case "CREDIT":
                    return new[]
                    {
                        CreateMockData(accountCode, 1, 12.34),
                        CreateMockData(accountCode, 1.3, 21.5),
                        CreateMockData(accountCode, 2.3, 0.1),
                        CreateMockData(accountCode, 4.6, 10),
                        CreateMockData(accountCode, 17, 55),
                        CreateMockData(accountCode, 14, 123456.789)
                    };
            }

            throw new ArgumentException("No account name found", nameof(accountCode));
        }

        private TransactionModel CreateMockData(string accountCode, double day, double amount)
        {
            var baseDate = new DateTime(2016, 01, 01);

            return new TransactionModel()
            {
                AccountCode = accountCode,
                Time = baseDate.AddDays(day),
                Amount = new MoneySerialisable() { Value = (decimal)amount }
            };
        }

        #endregion
    }
}
