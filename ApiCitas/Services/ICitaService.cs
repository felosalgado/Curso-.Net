using ApiCitas.Models;

namespace ApiCitas.Services
{
    public interface ICitaService 
    {
        Task<IEnumerable<Cita>> GetAllUsers();
        Task<Cita> GetUserById(int id);
        Task<int> CreateUser(Cita cita);
        Task<int> UpdateUser(Cita cita);
        Task<int> DeleteUser(int id);
    }
}
