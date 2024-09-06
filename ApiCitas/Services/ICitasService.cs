using ApiCitas.Models;

namespace ApiCitas.Services
{
    public interface ICitasService
    {
        Task<IEnumerable<Cita>> GetAllCitas();
        Task<Cita> GetCitasById(int id);
        Task<int> CreateCitas(Cita citas);
        Task<int> UpdateCitas(Cita citas);
        Task<int> DeleteCitas(int id);
    }
}
