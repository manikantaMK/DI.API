using DI.API.Models;

namespace DI.API.Repository
{
    public class AccountRepository : IAccountRepository
    {

        private static List<Account> _accounts;
        public AccountRepository()
        {
            _accounts = new List<Account>()
            {
                new Account(Guid.NewGuid(), "Account1", Guid.NewGuid()),
                new Account(Guid.Parse("4021da0f-99e2-4528-a2bc-39f9e7000a66"), "Account1", Guid.Parse("5921da0f-99e2-4528-a2bc-39f9e7000a66")),
            };
        }
        public Task<Account?> GetAccountByIdAsync(Guid accountID)
        {
            return Task.FromResult(_accounts.Find(x => x.AccountID == accountID));

        }
        public Task<List<Account>> GetAccountsAsync()
        {
            return Task.FromResult(_accounts);
        }
    }
}
