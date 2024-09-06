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
        public async Task CreateCitas_ReturnsOkResult_WithListOfCitas()
        {

            var newCita = new Citas
            {
                CitaID = 3,
                UsuarioID = 1,
                FechaCita = DateTime.Now,
                Descripcion = "Cita Medicina G",
                Lugar = "Consultorio",
                Estado = "Pendiente",
                FechaCreacion = DateTime.Now

                //  CitaID = 3,
                //Descripcion = "Description new",
                //Estado = "Estado",
                //FechaCita = DateTime.Now,
                //FechaCreacion = DateTime.Now,
                //Lugar = "Sala 3",
                //UsuarioID = 1



            };
            _citaService.CreateCita(Arg.Any<Citas>()).Returns(newCita.CitaID);

            var result = await _controller.CreateCita(newCita);

            var okResult = Assert.IsType<CreatedAtActionResult>(result);
            var returnValue = Assert.IsType<Citas>(okResult.Value);
            Assert.True(returnValue.CitaID > 1);
            Assert.Equal(3, returnValue.CitaID);
        }

    }
}
