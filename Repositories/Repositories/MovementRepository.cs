using Contracts.Interfaces;
using Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories.Repositories
{
    public class MovementRepository : IMovementRepository
    {
        private DatabaseContext _context;
        public MovementRepository(DatabaseContext context)
        {
            _context = context;
        }
        public async Task<Movement?> CreateMovement(Movement movement)
        {
            _context.Movements.Add(movement);
            await _context.SaveChangesAsync();
            var sa = _context.SavingsAccounts.FirstOrDefault(x => x.Id == movement.SavingsAccountId);
            if (movement.Amount > sa.Balance)
                return null;
            if(sa != null)
            {
                sa.Balance += movement.Amount;
                await _context.SaveChangesAsync();
            }
            return movement;
        }
        public List<Movement> GetMovementsBySavingsAccountId(int id)
        {
            return _context.Movements.Where(x=>x.SavingsAccountId == id).ToList();
        }
     

    }
}
