using ApiCitas.Controllers;
using ApiCitas.Models;
using ApiCitas.Services;
using Microsoft.AspNetCore.Mvc;
using NSubstitute;

namespace CitasTest
{
    public class CitasControllerTests
    {
        private readonly ICitaService _citaService = Substitute.For<ICitaService>();
        private readonly CitasController _citasController;

        public CitasControllerTests()
        {
            _citasController = new CitasController(_citaService);
        }

        [Fact]
        public async Task CreateCita_ReturnsCreatedAtActionResult_WhenCitaIsValid()
        {
            // Arrange
            var cita = new Cita
            {
                CitaID = 1,
                UsuarioID = 2,
                FechaCita = System.DateTime.Now,
                Descripcion = "Consulta general",
                Lugar = "Clinica",
                Estado = "Pendiente",
                FechaCreacion = System.DateTime.Now,
                FechaModificacion = System.DateTime.Now
            };

            // Act
            var result = await _citasController.CreateCita(cita);

            // Assert
            await _citaService.Received(1).CreateCita(cita);

            var actionResult = Assert.IsType<CreatedAtActionResult>(result);
            var createdCita = Assert.IsType<Cita>(actionResult.Value);
            Assert.Equal(cita.CitaID, createdCita.CitaID);
        }


    }
}