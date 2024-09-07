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
        private readonly ICitasService _citaService;
        private readonly CitasController _controller;

        public CitasControllerTests()
        {
            _citaService = Substitute.For<ICitasService>();
            _controller = new CitasController(_citaService);
        }



        [Fact]
        public async Task GetAllCitas_ReturnsOkResult_ListaDeCitas()
        {
            var testCitas = new List<Cita>
            {
                new Cita { CitaID = 1, UsuarioID = 100, Descripcion = "Consulta Externa", FechaCita = DateTime.Parse("2024-09-06") },
                new Cita { CitaID = 2, UsuarioID = 200, Descripcion = "Dermatología", FechaCita = DateTime.Parse("2024-09-06") }
            };
            _citaService.GetAllCitas().Returns(testCitas);

            var result = await _controller.GetAllCitas();

            var okResult = Assert.IsType<OkObjectResult>(result.Result);
            var returnValue = Assert.IsType<List<Cita>>(okResult.Value);
            Assert.Equal(2, returnValue.Count);
            
            Assert.Equal(1, returnValue[0].CitaID);
            Assert.Equal(100, returnValue[0].UsuarioID);
            Assert.Equal("Consulta Externa", returnValue[0].Descripcion);
            Assert.Equal(DateTime.Parse("2024-09-06"), returnValue[0].FechaCita);

            Assert.Equal(2, returnValue[1].CitaID);
            Assert.Equal(200, returnValue[1].UsuarioID);
            Assert.Equal("Dermatología", returnValue[1].Descripcion);
            Assert.Equal(DateTime.Parse("2024-09-06"), returnValue[1].FechaCita);
        }



        [Fact]
        public async Task CreateCita_ReturnsNuevaCita()
        {
            var newCita = new Cita
            {
                CitaID = 0,
                UsuarioID = 100,
                FechaCita = DateTime.Parse("2024-09-06"),
                Descripcion = "Consulta Externa",
                Lugar = "Consultorio 1",
                Estado = EstadoCita.Pendiente,
                FechaCreacion = DateTime.Now,
                FechaModificacion = null
            };

            var result = await _controller.CreateCita(newCita);

            var createdAtActionResult = Assert.IsType<CreatedAtActionResult>(result);
            var returnValue = Assert.IsType<Cita>(createdAtActionResult.Value);

            Assert.Equal(newCita.CitaID, returnValue.CitaID);
            Assert.Equal(newCita.UsuarioID, returnValue.UsuarioID);
            Assert.Equal(newCita.Descripcion, returnValue.Descripcion);
            Assert.Equal(newCita.FechaCita, returnValue.FechaCita);
            Assert.Equal(newCita.Lugar, returnValue.Lugar);
            Assert.Equal(newCita.Estado, returnValue.Estado);
        }

    }
}
