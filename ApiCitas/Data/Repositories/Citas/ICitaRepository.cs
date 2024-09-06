using ApiCitas.Models;

namespace ApiCitas.Data.Repositories.Citas
{
    public interface ICitaRepository
    {
        Task<IEnumerable<Cita>> GetAll();
        Task<Cita> GetById(int id);
        Task<int> Create(Cita cita);
        Task<int> Update(Cita cita);
        Task<int> Delete(int id);
    }
}
