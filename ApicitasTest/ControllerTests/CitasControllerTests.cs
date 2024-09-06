namespace ApiCitasTest.ControllerTests
{
    using Moq;
    using Xunit;
    using System.Collections.Generic;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using ApiCitas.Services;
    using ApiCitas.Models;
    using ApiCitas.Controllers;
    using NSubstitute;

    public class CitasControllerTests
    {
        private readonly Mock<ICitaService> _mockCitaService;
        private readonly CitasController _controller;

        public CitasControllerTests()
        {
            // Crear un Mock del servicio de citas
            _mockCitaService = new Mock<ICitaService>();

            // Pasar el servicio mockeado al controlador
            _controller = new CitasController(_mockCitaService.Object);
        }

        [Fact]
        public async Task GetAllCitas_ReturnsOkResult_WithListOfCitas()
        {
            // Arrange
            var mockCitas = new List<Cita>
        {
            new Cita { CitaID = 1, Descripcion = "Cita 1" },
            new Cita { CitaID = 2, Descripcion = "Cita 2" }
        };
            _mockCitaService.Setup(service => service.GetAllCitas()).ReturnsAsync(mockCitas);

            // Act
            var result = await _controller.GetAllCitas();

            // Assert
            var okResult = Assert.IsType<OkObjectResult>(result.Result);
            var returnCitas = Assert.IsType<List<Cita>>(okResult.Value);
            Assert.Equal(2, returnCitas.Count);
        }

        [Fact]
        public async Task GetCitaById_ReturnsOkResult_WithCita()
        {
            // Arrange
            var mockCita = new Cita { CitaID = 1, Descripcion = "Consulta médica" };
            _mockCitaService.Setup(service => service.GetCitaById(1)).ReturnsAsync(mockCita);

            // Act
            var result = await _controller.GetCitaById(1);

            // Assert
            var okResult = Assert.IsType<OkObjectResult>(result.Result);
            var returnCita = Assert.IsType<Cita>(okResult.Value);
            Assert.Equal(1, returnCita.CitaID);
        }

        [Fact]
        public async Task GetCitaById_ReturnsNotFound_WhenCitaNotFound()
        {
            // Arrange
            _mockCitaService.Setup(service => service.GetCitaById(It.IsAny<int>())).ReturnsAsync((Cita)null);

            // Act
            var result = await _controller.GetCitaById(1);

            // Assert
            Assert.IsType<NotFoundResult>(result.Result);
        }

        [Fact]
        public async Task CreateCita_ReturnsCreatedAtActionResult()
        {
            // Arrange
            var newCita = new Cita { CitaID = 3, Descripcion = "Cita nueva" };
            _mockCitaService.Setup(service => service.CreateCita(newCita)).ReturnsAsync(newCita.CitaID);

            // Act
            var result = await _controller.CreateCita(newCita);

            // Assert
            var createdAtActionResult = Assert.IsType<CreatedAtActionResult>(result);
            var returnCita = Assert.IsType<Cita>(createdAtActionResult.Value);
            Assert.Equal(3, returnCita.CitaID);
        }


        [Fact]
        public async Task UpdateCita_ReturnsNoContentResult_WhenSuccessful()
        {
            // Arrange
            var updatedCita = new Cita { CitaID = 1, Descripcion = "Cita actualizada" };

            // Suponemos que el método devuelve el ID de la cita actualizada
            _mockCitaService.Setup(service => service.UpdateCita(updatedCita)).ReturnsAsync(updatedCita.CitaID);

            // Act
            var result = await _controller.UpdateCita(1, updatedCita);

            // Assert
            Assert.IsType<NoContentResult>(result);
        }


        [Fact]
        public async Task UpdateCita_ReturnsBadRequest_WhenIdsDoNotMatch()
        {
            // Arrange
            var updatedCita = new Cita { CitaID = 2, Descripcion = "Cita actualizada" };

            // Act
            var result = await _controller.UpdateCita(1, updatedCita);

            // Assert
            Assert.IsType<BadRequestResult>(result);
        }

        [Fact]
        public async Task DeleteCita_ReturnsNoContentResult_WhenSuccessful()
        {
            // Arrange
            _mockCitaService.Setup(service => service.DeleteCita(1)).ReturnsAsync(1);

            // Act
            var result = await _controller.DeleteCita(1);

            // Assert
            Assert.IsType<NoContentResult>(result);
        }
    }

}