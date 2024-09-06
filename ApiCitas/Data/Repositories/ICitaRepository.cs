using ApiCitas.Models;

namespace ApiCitas.Data.Repositories
{
    public interface ICitaRepository
    {

        Task<Cita> GetById(int id);
        Task<int> Create(Cita user);
        Task<int> Update(Cita user);
        Task<int> Delete(int id);
        Task<IEnumerable<Cita>> GetAll();
    }
}
