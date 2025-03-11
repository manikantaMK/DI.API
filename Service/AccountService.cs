using DI.API.Models;
using DI.API.Repository;
using CSharpFunctionalExtensions;
namespace DI.API.Service
{
    public class AccountService : IAccountService
    {
        private readonly IAccountRepository _accountRepository;
        private readonly ICardService _cardService;
        public AccountService(IAccountRepository accountRepository, ICardService cardService)
        {
            _accountRepository = accountRepository;
            _cardService = cardService;
        }
        public async Task<Result<Account, string>> Bind(Guid AccountID, Guid CardID)
        {
            var Account = await _accountRepository.GetAccountByIdAsync(AccountID);
            if (Account is null)
            {
                return Result.Failure<Account, string>("No validaccounf=tID provided");
            }
            else
            {
                var card = await _cardService.GetCardByIdAsync(CardID);
                if (card.IsFailure)
                {
                    return Result.Failure<Account, string>(card.Error);
                }
                else
                {
                    var newAccount = Account.WithCardId(CardID);
                    return Result.Success<Account, string>(newAccount);
                }
            }
        }

        public async Task<List<Account>> GetAllAsync()
        {
            return await _accountRepository.GetAccountsAsync();
        }
    }
}
