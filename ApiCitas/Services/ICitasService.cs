using ApiCitas.Models;

namespace ApiCitas.Services
{
    public interface ICitasService
    {
        Task<IEnumerable<Cita>> GetAllCitas();
        Task<Cita> GetCitaById(int id);
        Task<int> CreateCita(Cita cita);
        Task<int> UpdateCita(Cita cita);
        Task<int> DeleteCita(int id);
    }
}
