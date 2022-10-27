using Contracts.Interfaces;
using Entities.Models;
using Microsoft.AspNetCore.Mvc;

namespace WebApplication1.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class MovementsController : ControllerBase
    {
        private IMovementRepository movementRepository;
        public MovementsController(IMovementRepository _movementRepository)
        {
            movementRepository = _movementRepository;
        }
        [HttpPost("CreateMovement")]
        public Task<Movement?> CreateMovement(Movement movement)
        {
            return movementRepository.CreateMovement(movement);
        }
        [HttpGet("GetByAccount/{id}")]
        public List<Movement> GetMovementsByAccountId(int id)
        {
            return movementRepository.GetMovementsBySavingsAccountId(id);
        }
    }
}
