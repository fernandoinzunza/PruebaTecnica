using Contracts.Interfaces;
using Entities.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebApplication1.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ClientsController : ControllerBase
    {

        private IClientRepository clientRepository;
        public ClientsController(IClientRepository _clientRepository)
        {
            clientRepository = _clientRepository;
        }
        [HttpPost("CreateClient")]
        public Task<Client?> CreateClient(Client client)
        {
            return clientRepository.CreateClient(client);
        }
        [HttpGet("GetClients")]
        public List<Client>? GetClients()
        {
            return clientRepository.GetClients();
        }
        [HttpGet("GetById/{id}")]
        public Client? GetClientById(int id)
        {
            return clientRepository.GetClientById(id);
        }
    }
}
