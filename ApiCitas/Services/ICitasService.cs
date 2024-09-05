using ApiCitas.Models;

namespace ApiCitas.Services
{
    public interface ICitasService
    {
        Task<IEnumerable<Citas>> GetAllCitas();
        Task<Citas> GetCitasById(int id);
        Task<int> CreateCitas(Citas citas);
        Task<int> UpdateCitas(Citas citas);
        Task<int> DeleteCitas(int id);
    }
}
