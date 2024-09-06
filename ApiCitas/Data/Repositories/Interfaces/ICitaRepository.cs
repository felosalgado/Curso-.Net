using ApiCitas.Models;

namespace ApiCitas.Data.Repositories.Interfaces
{
    public interface ICitaRepository
    {
        Task<Cita?> Get(int id);
        Task<int> Add(Cita cita);
        Task<int> Update(Cita cita);
        Task<int> Delete(int id);
        Task<IEnumerable<Cita>> Get();
    }
}
