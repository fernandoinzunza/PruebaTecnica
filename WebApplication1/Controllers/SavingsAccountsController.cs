using Contracts.Interfaces;
using Entities.Models;
using Microsoft.AspNetCore.Mvc;

namespace WebApplication1.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class SavingsAccountsController : ControllerBase
    {
        private ISavingsAccountRepository savingsAccountRepository;
        public SavingsAccountsController(ISavingsAccountRepository _savingsAccountRepository)
        {
            savingsAccountRepository = _savingsAccountRepository;
        }
        [HttpPost("CreateSavingsAccount")]
        public async Task<ActionResult> CreateSavingsAccountAsync(SavingsAccount savingsAccount)
        {
            var sa = await savingsAccountRepository.CreateSavingsAccount(savingsAccount);
            return sa == null ? BadRequest("El numero de cuenta ya existe!!") : Ok(savingsAccount);

        }
        [HttpGet("SavingsAccounts/{id}")]
        public List<SavingsAccount> GetSavingsAccountByClientId(int id)
        {
            return savingsAccountRepository.GetSavingsAccountsByClientId(id);
        }
        [HttpGet("SavingsAccounts")]
        public List<SavingsAccount> GetSavingsAccounts()
        {
            return savingsAccountRepository.GetSavingsAccounts();
        }
        [HttpGet("GetById/{id}")]
        public SavingsAccount? GetSavingsAccountById(int id)
        {
            return savingsAccountRepository.GetSavingsAccountById(id);
        }
    }
}
