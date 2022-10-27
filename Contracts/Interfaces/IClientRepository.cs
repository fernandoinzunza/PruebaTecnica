using Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contracts.Interfaces
{
    public interface IClientRepository
    {
        public Task<Client?> CreateClient(Client client);
        public List<Client>? GetClients();
        public Client? GetClientById(int id);
    }
}
