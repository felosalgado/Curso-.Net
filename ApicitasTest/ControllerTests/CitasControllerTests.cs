using ApiCitas.Controllers;
using ApiCitas.Models;
using ApiCitas.Services;
using ApiCitas.Services.Interfaces;
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
        private readonly ICitaService _service;
        private readonly CitasController _controller;

        public CitasControllerTests()
        {
            _service = Substitute.For<ICitaService>();
            _controller = new CitasController(_service);
        }

        [Fact]
        public async Task Get_ReturnsOkResult_WithListOfCitas()
        {
            // Arrange
            var testUsers = new List<Cita>
        {
            new Cita { CitaID = 1, Descripcion = "Description", Estado="Estado", FechaCita=DateTime.Now, FechaCreacion=DateTime.Now, Lugar="Sala 1", UsuarioID=1 },
            new Cita { CitaID = 2, Descripcion = "Description 2", Estado="Estado", FechaCita=DateTime.Now, FechaCreacion=DateTime.Now, Lugar="Sala 2", UsuarioID=1 },
        };
            _service.GetAllCitas().Returns(testUsers);

            // Act
            var result = await _controller.Get();

            // Assert
            var okResult = Assert.IsType<OkObjectResult>(result.Result);
            var returnValue = Assert.IsType<List<Cita>>(okResult.Value);
            Assert.Equal(2, returnValue.Count);
            Assert.Equal("Description", returnValue[0].Descripcion);
            Assert.Equal("Description 2", returnValue[1].Descripcion);
        }

        [Fact]
        public async Task GetOne_ReturnsOkResult_WithCita()
        {
            // Arrange
            var testUsers =
            new Cita { CitaID = 1, Descripcion = "Description", Estado = "Estado", FechaCita = DateTime.Now, FechaCreacion = DateTime.Now, Lugar = "Sala 1", UsuarioID = 1 };
          
            _service.GetCitaById(1).Returns(testUsers);

            // Act
            var result = await _controller.Get(1);

            // Assert
            var okResult = Assert.IsType<OkObjectResult>(result.Result);
            var returnValue = Assert.IsType<Cita>(okResult.Value);            
            Assert.Equal(testUsers.CitaID, returnValue.CitaID);
            
        }

        [Fact]
        public async Task UpdateCita_ReturnsOkResult_WithNumberOfRowsAffected()
        {
            // Arrange
            var updatedCita = new Cita
            {
                CitaID = 1, 
                Descripcion = "Updated Description",
                Estado = "Updated Estado",
                FechaCita = DateTime.Now.AddDays(1), 
                FechaCreacion = DateTime.Now,
                Lugar = "Updated Sala",
                UsuarioID = 1
            };

            int rowsAffected = 1; 

            _service.UpdateCita(updatedCita).Returns(rowsAffected);
            updatedCita.Descripcion = "Hola mundo";
            // Act
            var result = await _controller.UpdateCita(updatedCita.CitaID, updatedCita);

            
            var okResult = Assert.IsType<NoContentResult>(result); 
            Assert.Equal(204, okResult.StatusCode); 
            //Assert.Equal(rowsAffected, okResult); 
        }

        [Fact]
        public async Task DeleteCita_ReturnsOkResult_WithNumberOfRowsAffected()
        {
            // Arrange
            int citaId = 1;
            int rowsAffected = 1; 

            _service.DeleteCita(citaId).Returns(rowsAffected); 
            // Act
            var result = await _controller.DeleteCita(citaId);

            // Assert
            var okResult = Assert.IsType<NoContentResult>(result); 
            Assert.Equal(204, okResult.StatusCode); 
           
        }

        [Fact]
        public async Task CreateCitas_ReturnsOkResult_WithListOfCitas()
        {

            var newCita = new Cita
            {
                CitaID = 3,
                Descripcion = "Description new",
                Estado = "Estado",
                FechaCita = DateTime.Now,
                FechaCreacion = DateTime.Now,
                Lugar = "Sala 3",
                UsuarioID = 1
            };
            _service.CreateCita(Arg.Any<Cita>()).Returns(newCita.CitaID);

            var result = await _controller.CreateCita(newCita);

            var okResult = Assert.IsType<CreatedAtActionResult>(result);
            var returnValue = Assert.IsType<Cita>(okResult.Value);
            Assert.True(returnValue.CitaID > 1);
            Assert.Equal(3, returnValue.CitaID);
        }

    }
}
