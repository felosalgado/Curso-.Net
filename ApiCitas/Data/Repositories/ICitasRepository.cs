using ApiCitas.Models;

namespace ApiCitas.Data.Repositories
{
    public interface ICitasRepository
    {
        Task<Citas> GetById(int id);
        Task<int> Create(Citas citas);
        Task<int> Update(Citas citas);
        Task<int> Delete(int id);
        Task<IEnumerable<Citas>> GetAll();
    }
}
