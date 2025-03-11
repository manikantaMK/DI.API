using DI.API.Models;
using DI.API.Service;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace DI.API.Controllers;

[ApiController]
[Route("[controller]")]
public class AccountController : ControllerBase
{
    private readonly IAccountService _accountService;
    public AccountController(IAccountService accountService)
    {
        _accountService = accountService;
    }
    [HttpGet]
    public async Task<IActionResult>GetAll()
    {
        return Ok( await _accountService.GetAllAsync());
    }
    [HttpPost]
    public async Task<IActionResult> Bind(Guid accountId, Guid cardId)
    {
        var bindResponse = await _accountService.Bind(accountId, cardId);
        if (bindResponse.IsSuccess)
        {
            return Ok(bindResponse.Value);
        }
        else
        {
            return NotFound();
        }
    }
}
