using CSharpFunctionalExtensions;
using DI.API.Models;

namespace DI.API.Service
{
    public interface IAccountService
    {
        Task<Result<Account, string>> Bind(Guid AccountID, Guid CardID);
        Task<List<Account>> GetAllAsync();
    }
}