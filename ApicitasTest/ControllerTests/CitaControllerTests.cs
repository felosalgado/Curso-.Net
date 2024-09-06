using ApiCitas.Controllers;
using ApiCitas.Models;
using ApiCitas.Services.Citas;
using Microsoft.AspNetCore.Mvc;
using NSubstitute;

namespace ApiCitasTest.ControllerTests
{
    public class CitaControllerTests
    {
        private readonly ICitaService _citaService;
        private readonly CitaController _controller;

        public CitaControllerTests()
        {
            _citaService = Substitute.For<ICitaService>();
            _controller = new CitaController(_citaService);
        }

        [Fact]
        public async Task CreateCita_ReturnsCreatedAtAction_WhenCitaIsValid()
        {
            // Arrange
            var testCita = new Cita
            {
                CitaID = 1,
                UsuarioID = 1,
                FechaCita = System.DateTime.Now,
                Descripcion = "Consulta médica",
                Lugar = "Hospital Central",
                Estado = "Pendiente"
            };

            _citaService.CreateCita(testCita).Returns(testCita.CitaID);

            // Act
            var result = await _controller.CreateCita(testCita);

            // Assert
            var createdAtActionResult = Assert.IsType<CreatedAtActionResult>(result);
            Assert.Equal("GetCitaById", createdAtActionResult.ActionName);
            Assert.Equal(testCita.CitaID, createdAtActionResult.RouteValues["id"]);
            var returnValue = Assert.IsType<Cita>(createdAtActionResult.Value);
            Assert.Equal(testCita.CitaID, returnValue.CitaID);
        }
    }
}
