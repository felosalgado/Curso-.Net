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
    public class CitaControllerTests
    {
        private readonly ICitaService _citaService;
        private readonly CitasController _controller;

        public CitaControllerTests()
        {
            _citaService = Substitute.For<ICitaService>();
            _controller = new CitasController(_citaService);
        }

        [Fact]
        public async Task GetAllCitas_ReturnsOkResult_WithListOfCitas()
        {
            // Arrange
            var testCita = new List<Cita>
        {
            new Cita { CitaID = 1, Descripcion = "Cita 1" },
            new Cita { CitaID = 2, Descripcion = "Cita 2" }
        };
            _citaService.GetAllCitas().Returns(testCita);

            // Act
            var result = await _controller.GetAllCitas();

            // Assert
            var okResult = Assert.IsType<OkObjectResult>(result.Result);
            var returnValue = Assert.IsType<List<Cita>>(okResult.Value);
            Assert.Equal(2, returnValue.Count);
            Assert.Equal("Cita 1", returnValue[0].Descripcion);
            Assert.Equal("Cita 2", returnValue[1].Descripcion);
        }

    }
}
