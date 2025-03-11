using DI.API.Models;

namespace DI.API.Repository
{
    public interface ICardRepository
    {
        Task<Card?> GetCardByIdAsync(Guid Cardid);
    }
}