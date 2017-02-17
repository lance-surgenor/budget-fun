using System.Runtime.Serialization;

namespace Tegdub.WebApi.Models
{
    [DataContract(Name = "Account")]
    public class AccountModel
    {
        [DataMember(Name = "Name")]
        public string Name { get; set; }

        [DataMember(Name="Code")]
        public string Code { get; set; }

        public static AccountModel FromAccount(Domain.Account.Account account)
        {
            return new AccountModel()
            {
                Name = account.Name,
                Code = account.Code
            };
        }
    }
}
