using Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contracts.Interfaces
{
    public interface IMovementRepository
    {
        public Task<Movement?> CreateMovement(Movement movement);
        public List<Movement> GetMovementsBySavingsAccountId(int id);
        
    }
}
