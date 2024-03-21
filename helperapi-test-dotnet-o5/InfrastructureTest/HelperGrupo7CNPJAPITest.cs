using helper_api_dotnet_o5.Infrastructure;
using helper_api_dotnet_o5.Models.Paises;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace helperapi_test_dotnet_o5.InfrastructureTest
{
    public class HelperGrupo7CNPJAPITest
    {
        private const string ENDPOINT = "https://brasilapi.com.br/api/cnpj/v1/";

        [Fact]
        public async Task ExecutaMetodoGET_QuandoAPIERotaValida_EntaoRetornaObjetoValido()
        {
            //Arrange
            var helperAPI = new HelperAPI(ENDPOINT);
            var route = "60701190000104";

            //Act
            var result = await helperAPI.MetodoGET<ConsultaCPNJOutPut>(route);

            //Assert
            Assert.NotNull(result);
            Assert.IsType<ConsultaCPNJOutPut>(result);
            Assert.True(!String.IsNullOrEmpty(result.Cnpj));
        }

    }
}
