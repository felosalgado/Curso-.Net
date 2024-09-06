using ApiCitas.Models;

namespace ApiCitas.Services.Citas
{
    public interface ICitaService
    {
        Task<IEnumerable<Cita>> GetAllCitas();
        Task<Cita> GetCitaById(int id);
        Task<int> CreateCita(Cita cita);
        Task<int> UpdateCita(Cita cita);
        Task<int> DeleteCita(int id);
    }
}
