using ApiCitas.Application.Services;
using ApiCitas.Domain.Contracts;
using ApiCitas.Domain.Models;
using Moq;
using System.Net;
using TestApiCitas.Mocks;

namespace TestApiCitas.Test
{
    [TestClass]
    public class TestCitas
    {
        [TestMethod]
        public void GetCitas_Ok()
        {
            //Arrange
            var mockCitas = MockDataCitas.GetMockCitas();
            Mock<ICitaRepository> citaRepository = new();
            CitaServices citaServicio = new(citaRepository.Object);

            citaRepository.Setup(a => a.GetAll()).Returns(Task.FromResult<IEnumerable<Cita>>(mockCitas));

            //Act
            var citas = citaServicio.GetAllCitas();

            //Assert
            Assert.AreEqual("Lugar 1", citas.Result.FirstOrDefault().Lugar);
            Assert.IsNotNull(citas.Result);
            citaRepository.Verify(a => a.GetAll(), Times.Once);
        }

        [TestMethod]
        public void GetCita_Ok()
        {
            //Arrange
            var mockCita = MockDataCitas.GetMockCita();
            Mock<ICitaRepository> citaRepository = new();
            CitaServices citaServicio = new(citaRepository.Object);

            citaRepository.Setup(a => a.GetById(1)).Returns(Task.FromResult<Cita>(mockCita));

            //Act
            var cita = citaServicio.GetCitaById(1);

            //Assert
            Assert.AreEqual("Estado 1", cita.Result.Estado);
            Assert.AreEqual("Descripcion 1", cita.Result.Descripcion);
            Assert.IsNotNull(cita.Result);
            citaRepository.Verify(a => a.GetById(1), Times.Once);
        }
    }
}
