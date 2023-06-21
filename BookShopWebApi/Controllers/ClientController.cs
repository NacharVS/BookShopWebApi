using Application;
using Core;
using Microsoft.AspNetCore.Mvc;

namespace BookShopWebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClientController : Controller
    {
        private readonly IClientRepo _clientRepo;

        public ClientController(IClientRepo Repo)
        {
            _clientRepo = Repo;
        }

        [HttpGet("GetAllClients")]
        public async Task<ActionResult<IEnumerable<Client>>> GetAllClients()
        {
            var clients = await _clientRepo.GetClients();
            return Ok(clients);
        }
    }
}
