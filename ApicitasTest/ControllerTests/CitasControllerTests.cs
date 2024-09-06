using NSubstitute;
using Xunit;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ApiCitas.Controllers;
using ApiCitas.Services;
using ApiCitas.Models;
using Microsoft.AspNetCore.Mvc;

namespace ApiCitasTest.ControllerTests
{
    public class CitasControllerTests
    {
        private readonly ICitaService _citaService;
        private readonly CitasController _controller;

        public CitasControllerTests()
        {
            _citaService = Substitute.For<ICitaService>();
            _controller = new CitasController(_citaService);
        }

        [Fact]
        public async Task GetAllCitas_ReturnsOkResult_WithListOfUsers()
        {
            // Arrange
            var testCitas = new List<Citas>
        {
            new Citas { CitaID = 1, UsuarioID = 2, FechaCita = Convert.ToDateTime("2024-09-06"), Descripcion = "Prueba",Lugar = "prueba",Estado = "estadoprueba",
                FechaCreacion = Convert.ToDateTime("2024-09-06") ,FechaModificacion = Convert.ToDateTime("2024-09-06") },
                


    };
            _citaService.GetAllCitas().Returns(testCitas);

            // Act
            var result = await _controller.GetAllCitas();

            // Assert
            var okResult = Assert.IsType<OkObjectResult>(result.Result);
            var returnValue = Assert.IsType<List<Citas>>(okResult.Value);
            Assert.Equal(2, returnValue.Count);
            Assert.Equal("Prueba", returnValue[0].Lugar);
            Assert.Equal("Prueba1", returnValue[1].Lugar);
        }

    }
}
