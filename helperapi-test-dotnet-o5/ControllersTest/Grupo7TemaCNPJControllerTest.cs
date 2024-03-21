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
            Assert.NotNull(result);
            Assert.IsType<OkObjectResult>(result);
        }

        [Fact]
        public void ExecutaRotaCNPJGET_QuandoAPIDisponivelEParametrosInvalidos_EntaoRetornaNotFound()
        {
            //Arrange
            var loggerMock = new Mock<ILogger<Grupo7TemaCNPJController>>();
            var controller = new Grupo7TemaCNPJController(loggerMock.Object);

            //Act
            var result = controller.Get2("12345670000104");

            //Assert
            Assert.IsType<NotFoundResult>(result);
        }

        [Fact]
        public void ExecutaRotaCNPJGET_QuandoAPIDisponivelECnpjInvalido_EntaoRetornaBadRequest()
        {
            //Arrange
            var loggerMock = new Mock<ILogger<Grupo7TemaCNPJController>>();
            var controller = new Grupo7TemaCNPJController(loggerMock.Object);

            //Act
            var result = controller.Get2("12345670000104443435");

            //Assert
            Assert.IsType<BadRequestObjectResult>(result);
        }

        [Theory]
        [InlineData("60701190000104")]
        [InlineData("12345670000104")]
        public void ExecutaRotaCNPJGET_QuandoAPIDisponivelEParametrosOK_EntaoRetornaObjetoValidoOuInvalido(string cnpj)
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
                Assert.IsType<NotFoundResult>(result);
        }
    }
}
