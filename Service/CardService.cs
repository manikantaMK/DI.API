using DI.API.Models;
using DI.API.Repository;
using CSharpFunctionalExtensions;
namespace DI.API.Service
{
    public class CardService : ICardService
    {
        private ICardRepository _cardrepository;
        public CardService(ICardRepository cardrepository)
        {
            _cardrepository = cardrepository;
        }
        public async Task<Result<Card, string>> GetCardByIdAsync(Guid cardId)
        {
            var card = await _cardrepository.GetCardByIdAsync(cardId);
            if (card is null)
            {
                return Result.Failure<Card, string>
                    ("Not a vaild card id");
            }
            return Result.Success<Card, string>(card);
        }
    }
}
