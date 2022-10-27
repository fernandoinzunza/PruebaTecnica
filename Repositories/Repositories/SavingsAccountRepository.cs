using Contracts.Interfaces;
using Entities.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories.Repositories
{
    public class SavingsAccountRepository : ISavingsAccountRepository
    {
        private DatabaseContext _context;
        public SavingsAccountRepository(DatabaseContext context)
        {
            _context = context;
        }
        public async Task<SavingsAccount> CreateSavingsAccount(SavingsAccount savingsAccount)
        {
            var sa = _context.SavingsAccounts.FirstOrDefault(x => x.AccountNumber == savingsAccount.AccountNumber);
            if (sa == null)
            {
                _context.SavingsAccounts.Add(savingsAccount);
                await _context.SaveChangesAsync();
                return savingsAccount;
            }
            else
                return null;
        }

        public List<SavingsAccount> GetSavingsAccounts()
        {
            return _context.SavingsAccounts.ToList();
        }

        public List<SavingsAccount> GetSavingsAccountsByClientId(int clientId)
        {
            return _context.SavingsAccounts.Where(x => x.ClientId == clientId).ToList();
        }
        public SavingsAccount? GetSavingsAccountById(int id)
        {
            return _context.SavingsAccounts.FirstOrDefault(x => x.Id == id);
        }
    }
}
