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
        private readonly ICitasService _ICitasService;
        private readonly CitasController _citasController;
        public CitasControllerTests()
        {
            _ICitasService = Substitute.For<ICitasService>();
            _citasController = new CitasController(_ICitasService);
        }

        [Fact]
        public async Task CreateCitasReturnOk()
        {
            #region Arrange
            var Citas = new Citas()
            {
                CitaID = 0,
                UsuarioID = 1,
                Descripcion = "Prueba2",
                Lugar = "Mosquera",
                Estado = "Pendiente",
                FechaCita = DateTime.Now,
                FechaCreacion = DateTime.Now,
                FechaModificacion = null
            };

            await _ICitasService.CreateCitas(Citas);
            #endregion
            #region Act
            var result = await _citasController.CreateCitas(Citas);
            #endregion
            #region Assert
            var okResult = Assert.IsType<CreatedAtActionResult>(result);
            var returnValue = Assert.IsType<Citas>(okResult.Value);
            #endregion


        }
    }
}
