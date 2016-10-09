using System.Collections.Generic;
using System.Web.Http;
using Tegdub.Infrastructure;
using Tegdub.WebApi.Models;

namespace Tegdub.WebApi.Controllers
{
    public class FundsController
        : ApiController
    {
        public IEnumerable<FundModel>Get()
        {
            return new[]
            {
                new FundModel()
                {
                    Name = "Fund A",
                    Balance = new MoneySerialisable() {Value = 1.23m }
                },
                new FundModel()
                {
                    Name = "Fund B",
                    Balance = new MoneySerialisable() { Value = 45.67m }
                },
            };
        }
    }
}
