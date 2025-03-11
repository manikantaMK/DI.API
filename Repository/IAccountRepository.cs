using DI.API.Models;

namespace DI.API.Repository
{
    public interface IAccountRepository
    {
        Task<Account?> GetAccountByIdAsync(Guid accountID);
        Task<List<Account>> GetAccountsAsync();
    }
}