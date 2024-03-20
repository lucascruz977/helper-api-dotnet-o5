using helper_api_dotnet_o5.Controllers;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Moq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace helperapi_test_dotnet_o5.ControllersTest
{
    public class Grupo7TemaCNPJControllerTest
    {
        [Fact]
        public void ExecutaRotaCNPJGET_QuandoAPIDisponivelEParametrosOK_EntaoRetornaObjetoValido()
        {
            //Arrange
            var loggerMock = new Mock<ILogger<Grupo7TemaCNPJController>>();
            var controller = new Grupo7TemaCNPJController(loggerMock.Object);

            //Act
            var result = controller.Get2("60701190000104");

            //Assert
            Assert.IsType<OkObjectResult>(result);
        }

        [Fact]
        public void ExecutaRotaCNPJGET_QuandoAPIDisponivelEParametrosInvalidos_EntaoRetornaNoContent()
        {
            //Arrange
            var loggerMock = new Mock<ILogger<Grupo7TemaCNPJController>>();
            var controller = new Grupo7TemaCNPJController(loggerMock.Object);

            //Act
            var result = controller.Get2("5435643654654654654");

            //Assert
            Assert.IsType<NoContentResult>(result);
        }

        [Theory]
        [InlineData("60701190000104")]
        [InlineData("5435643654654654654")]
        public void ExecutaRotaPaisesGET_QuandoAPIDisponivelEParametrosOK_EntaoRetornaObjetoValidoOuInvalido(string cnpj)
        {
            //Arrange
            var loggerMock = new Mock<ILogger<Grupo7TemaCNPJController>>();
            var controller = new Grupo7TemaCNPJController(loggerMock.Object);

            //Act
            var result = controller.Get2(cnpj);

            //Assert
            if (cnpj == "60701190000104")
                Assert.IsType<OkObjectResult>(result);
            else
                Assert.IsType<NoContentResult>(result);
        }
    }
}
