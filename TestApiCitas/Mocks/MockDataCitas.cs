using ApiCitas.Domain.Models;

namespace TestApiCitas.Mocks
{
    public static class MockDataCitas
    {
        public static List<Cita> GetMockCitas()
        {
            return new List<Cita>
            {
                new Cita { Descripcion = "Descripcion 1", Estado = "Estado 1", Lugar = "Lugar 1" },
                new Cita { Descripcion = "Descripcion 2", Estado = "Estado 2", Lugar = "Lugar 2" }
            };
        }

        public static Cita GetMockCita()
        {
            return new Cita
            {
                Descripcion = "Descripcion 1",
                Estado = "Estado 1",
                Lugar = "Lugar 1"
            };
        }
    }
}
