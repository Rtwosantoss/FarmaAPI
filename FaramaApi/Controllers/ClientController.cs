using FaramaApi.Model;
using FaramaApi.Service;
using Microsoft.AspNetCore.Mvc;

namespace FaramaApi.Controllers
{
    [ApiController]
    [Route("[controller]")]

    public class ClientController : Controller            
    {
        private readonly ClientService _clientService;
        public ClientController(ClientService clientService) 
        {
            _clientService = clientService;
        }

        [HttpGet(Name = "GetClient")]
        public IActionResult MostrasCliente()
        {
            return Ok(_clientService.MostrasCliente());
        }
    }
}
