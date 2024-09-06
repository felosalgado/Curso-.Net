using ApiCitas.Models;

namespace ApiCitas.Data.Repositories
{
    public interface ICitasRepository
    {
        Task<Cita> GetById(int id);
        Task<int> Create(Cita citas);
        Task<int> Update(Cita citas);
        Task<int> Delete(int id);
        Task<IEnumerable<Cita>> GetAll();
    }
}
