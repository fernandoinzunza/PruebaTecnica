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
    public class ClientRepository : IClientRepository
    {
        private DatabaseContext _context;

        public ClientRepository(DatabaseContext context)
        {
            _context = context;
        }
        public async Task<Client?> CreateClient(Client client)
        {
            _context.Clients.Add(client);
            await _context.SaveChangesAsync();
            return client;
        }

        public List<Client>? GetClients()
        {
            return _context.Clients.ToList();
        }
        public Client? GetClientById(int id)
        {
            return _context.Clients.FirstOrDefault(x => x.Id == id);
        }
    }
}
