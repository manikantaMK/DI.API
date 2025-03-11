using DI.API.Models;

namespace DI.API.Repository
{
    public class CardRepository : ICardRepository
    {
        private static List<Card> _card;
        public CardRepository()
        {
            _card = new List<Card>()
            {
                new Card(Guid.NewGuid(), "Card1"),
                new Card(Guid.Parse("5921da0f-99e2-4528-a2bc-39f9e7000a66"),"card2"),
            };
        }
        public Task<Card?> GetCardByIdAsync(Guid Cardid)
        {
            return Task.FromResult(_card.Find(x => x.id == Cardid));

        }
    }
}
