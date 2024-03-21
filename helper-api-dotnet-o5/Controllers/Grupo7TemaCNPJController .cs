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
        private readonly ILogger<Grupo7TemaCNPJController> _logger;

        public Grupo7TemaCNPJController(ILogger<Grupo7TemaCNPJController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        [Route("{cnpj}")]
        [ProducesResponseType(typeof(ConsultaCPNJOutPut), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public IActionResult Get2(string cnpj)
        {
            var route = $"/{cnpj}";
            var api = new HelperAPI(ENDPOINT);

            try
            {
                if (cnpj.Length != 14)
                    return BadRequest("O cpnj não pode ser menor do que 14 caracteres");

                var result = api.MetodoGET<ConsultaCPNJOutPut>(route).Result;

                if (!String.IsNullOrEmpty(result.Cnpj))
                    return Ok(result);
                else
                    return NotFound();
            }
            catch (Exception ex)
            {

                return BadRequest(ex.Message);
            }


        }
    }
}
