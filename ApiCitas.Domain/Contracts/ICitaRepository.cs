using ApiCitas.Domain.Models;

namespace ApiCitas.Domain.Contracts
{
    public interface ICitaRepository
    {
        Task<Cita> GetById(int id);
        Task<Cita> Create(Cita cita);
        Task<Cita> Update(Cita cita);
        Task<Cita> Delete(int id);
        Task<IEnumerable<Cita>> GetAll();
    }
}
