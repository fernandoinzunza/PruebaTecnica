using Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contracts.Interfaces
{
    public interface ISavingsAccountRepository
    {
        public Task<SavingsAccount> CreateSavingsAccount(SavingsAccount savingsAccount);
        public List<SavingsAccount> GetSavingsAccountsByClientId(int clientId);
        public List<SavingsAccount> GetSavingsAccounts();
        public SavingsAccount? GetSavingsAccountById(int id);

    }
}
