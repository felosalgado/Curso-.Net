using ApiCitas.Controllers;
using ApiCitas.Models;
using ApiCitas.Services;
using Microsoft.AspNetCore.Mvc;
using NSubstitute;
using NSubstitute.Core;
using NSubstitute.ReturnsExtensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
        public async Task GetAllCitas_ReturnsOkResult_WithListOfCitas()
        {
            // Arrange
            var mockCitas = new List<Citas>
            {
            new Citas { CitaID = 1, Descripcion = "Cita 1" },
            new Citas { CitaID = 2, Descripcion = "Cita 2" }
        };
            _citaService.GetAllCitas().Returns(mockCitas);

            // Act
            var result = await _controller.GetAllCitas();

            // Assert
            var okResult = Assert.IsType<OkObjectResult>(result.Result);
            var returnValue = Assert.IsType<List<Citas>>(okResult.Value);
            Assert.Equal(2, returnValue.Count);
            Assert.Equal("Cita 1", returnValue[0].Descripcion);
            Assert.Equal("Cita 2", returnValue[1].Descripcion);
        }

        [Fact]
        public async Task GetCitaById_ReturnsOkResult_WithCita()
        {
            // Arrange
            var mockCita = new Citas { CitaID = 1, Descripcion = "Cita 1" };
            _citaService.GetCitaById(1).Returns(mockCita);

            // Act
            var result = await _controller.GetCitaById(1);

            // Assert
            var okResult = Assert.IsType<OkObjectResult>(result.Result);
            var returnCita = Assert.IsType<Citas>(okResult.Value);
            Assert.Equal("Cita 1", returnCita.Descripcion);
        }

        [Fact]
        public async Task GetCitaById_ReturnsNotFound_WhenCitaNotFound()
        {
            // Arrange
            _citaService.GetCitaById(1).Returns((Citas)null);

            // Act
            var result = await _controller.GetCitaById(1);

            // Assert
            Assert.IsType<NotFoundResult>(result.Result);
        }

        [Fact]
        public async Task CreateCita_ReturnsCreatedAtActionResult()
        {
            // Arrange
            var newCita = new Citas { CitaID = 1, Descripcion = "Nueva cita" };

            // Act
            var result = await _controller.CreateCita(newCita);

            // Assert
            var createdAtActionResult = Assert.IsType<CreatedAtActionResult>(result);
            var returnValue = Assert.IsType<Citas>(createdAtActionResult.Value);
            Assert.Equal("Nueva cita", returnValue.Descripcion);
        }


        [Fact]
        public async Task UpdateCita_ReturnsNoContentResult_WhenSuccessful()
        {
            // Arrange
            var updatedCita = new Citas { CitaID = 1, Descripcion = "Updated Cita" };

            // Act
            var result = await _controller.UpdateCita(1, updatedCita);

            // Assert
            Assert.IsType<NoContentResult>(result);
        }


        [Fact]
        public async Task UpdateCita_ReturnsBadRequest_WhenIdsDoNotMatch()
        {
            // Arrange
            var updatedCita = new Citas { CitaID = 1, Descripcion = "Updated Cita" };

            // Act
            var result = await _controller.UpdateCita(2, updatedCita);

            // Assert
            Assert.IsType<BadRequestResult>(result);
        }

        [Fact]
        public async Task DeleteCita_ReturnsNoContentResult_WhenSuccessful()
        {
            // Act
            var result = await _controller.DeleteCita(1);

            // Assert
            Assert.IsType<NoContentResult>(result);
        }
    }
}
