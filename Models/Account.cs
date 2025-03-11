namespace DI.API.Models
{
    public record Account(Guid AccountID, string AccountName, Guid CardID)
    {
        public Account WithCardId(Guid cardID)
        {
            return this with { CardID = cardID };
        }
    }
}
