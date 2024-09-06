using ApiCitas.Controllers;
using ApiCitas.Models;
using ApiCitas.Services;
using Microsoft.AspNetCore.Mvc;
using NSubstitute;
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
            var testCitas = new List<Cita>
        {
            new Cita { CitaID = 1, Descripcion = "Cita 1" },
            new Cita { CitaID = 2, Descripcion = "Cita 2" }
        };
            _citaService.GetAllCitas().Returns(testCitas);

            // Act
            var result = await _controller.GetAllUsers();

            // Assert
            var okResult = Assert.IsType<OkObjectResult>(result.Result);
            var returnValue = Assert.IsType<List<Cita>>(okResult.Value);
            Assert.Equal(2, returnValue.Count);
            Assert.Equal("Cita 1", returnValue[0].Descripcion);
            Assert.Equal("Cita 2", returnValue[1].Descripcion);
        }

        [Fact]
        public async Task GetCitaById_ReturnsOkResult_WithCita()
        {
            // Arrange
            var testCita = new Cita { CitaID = 1, Descripcion = "Cita 1" };
            _citaService.GetCitaById(1).Returns(testCita);

            // Act
            var result = await _controller.GetCitaById(1);

            // Assert
            var okResult = Assert.IsType<OkObjectResult>(result.Result);
            var returnValue = Assert.IsType<Cita>(okResult.Value);
            Assert.Equal("Cita 1", returnValue.Descripcion);
        }

        [Fact]
        public async Task GetCitaById_ReturnsNotFound_WhenCitaDoesNotExist()
        {
            // Arrange
            _citaService.GetCitaById(1).Returns((Cita)null);

            // Act
            var result = await _controller.GetCitaById(1);

            // Assert
            Assert.IsType<NotFoundResult>(result.Result);
        }

        [Fact]
        public async Task CreateCita_ReturnsCreatedAtActionResult()
        {
            // Arrange
            var newCita = new Cita { CitaID = 1, Descripcion = "New Cita" };

            // Act
            var result = await _controller.CreateCita(newCita);

            // Assert
            var createdAtActionResult = Assert.IsType<CreatedAtActionResult>(result);
            Assert.Equal("GetCitaById", createdAtActionResult.ActionName);
            Assert.Equal(1, createdAtActionResult.RouteValues["id"]);
            var returnValue = Assert.IsType<Cita>(createdAtActionResult.Value);
            Assert.Equal("New Cita", returnValue.Descripcion);
        }

        [Fact]
        public async Task UpdateCita_ReturnsNoContent_WhenCitaIsUpdated()
        {
            // Arrange
            var existingCita = new Cita { CitaID = 1, Descripcion = "Updated Cita" };

            // Act
            var result = await _controller.UpdateCita(1, existingCita);

            // Assert
            Assert.IsType<NoContentResult>(result);
        }

        [Fact]
        public async Task UpdateCita_ReturnsBadRequest_WhenIdDoesNotMatchCitaID()
        {
            // Arrange
            var existingCita = new Cita { CitaID = 1, Descripcion = "Updated Cita" };

            // Act
            var result = await _controller.UpdateCita(2, existingCita);

            // Assert
            Assert.IsType<BadRequestResult>(result);
        }

        [Fact]
        public async Task DeleteCita_ReturnsNoContent_WhenCitaIsDeleted()
        {
            // Act
            var result = await _controller.DeleteCita(1);

            // Assert
            Assert.IsType<NoContentResult>(result);
        }
    }

}
