using ApiCitas.Models;

namespace ApiCitas.Data.Repositories
{
    public interface ICitaRepository
    {
        Task<Citas> GetById(int id);
        Task<int> Create(Citas cita);
        Task<int> Update(Citas cita);
        Task<int> Delete(int id);
        Task<IEnumerable<Citas>> GetAll();
    }
}
