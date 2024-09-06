using ApiCitas.Models;

namespace ApiCitas.Data.Repositories
{
     public interface ICitaRepository
    {
        Task<Cita> GetById(int id);
        Task<int> Create(Cita cita);
        Task<int> Update(Cita cita);
        Task<int> Delete(int id);
        Task<IEnumerable<Cita>> GetAll();
    }
}
