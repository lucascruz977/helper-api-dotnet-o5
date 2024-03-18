using helper_api_dotnet_o5.Infrastructure;
using helper_api_dotnet_o5.Models.Paises;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace helper_api_dotnet_o5.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Grupo7TemaCNPJController : ControllerBase
    {
        private const string ENDPOINT = "https://brasilapi.com.br/api/cnpj/v1/";
        private readonly ILogger<CountryController> _logger;

        public Grupo7TemaCNPJController(ILogger<CountryController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        [Route("{cnpj}")]
        [ProducesResponseType(typeof(ConsultaCPNJOutPut), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        [ProducesResponseType(StatusCodes.Status502BadGateway)]
        public IActionResult Get2(string cnpj)
        {
            var route = $"/{cnpj}";
            var api = new HelperAPI(ENDPOINT);
            var result = api.MetodoGET<ConsultaCPNJOutPut>(route).Result;

           return Ok(result);

        }
    }
}
