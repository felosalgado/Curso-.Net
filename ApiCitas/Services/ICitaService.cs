using ApiCitas.Models;

namespace ApiCitas.Services
{
    public interface ICitaService
    {
        Task<IEnumerable<Citas>> GetAllCitas();
        Task<Citas> GetCitaById(int id);
        Task<int> CreateCita(Citas cita);
        Task<int> UpdateCita(Citas cita);
        Task<int> DeleteCita(int id);
    }
}
