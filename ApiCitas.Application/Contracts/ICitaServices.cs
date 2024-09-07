using ApiCitas.Domain.Models;

namespace ApiCitas.Application.Contracts
{
    public interface ICitaServices
    {
        Task<IEnumerable<Cita>> GetAllCitas();
        Task<Cita> GetCitaById(int id);
        Task<Cita> CreateCita(Cita cita);
        Task<Cita> UpdateCita(Cita cita);
        Task<Cita> DeleteCita(int id);
    }
}
