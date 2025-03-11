using CSharpFunctionalExtensions;
using DI.API.Models;

namespace DI.API.Service
{
    public interface ICardService
    {
        Task<Result<Card, string>> GetCardByIdAsync(Guid cardId);
    }
}