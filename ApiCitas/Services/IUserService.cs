using ApiCitas.Models;

namespace ApiCitas.Services
{
    public interface IUserService
    { //esto es para hacer calculos o algo con los datos 
        Task<IEnumerable<User>> GetAllUsers();
        Task<User> GetUserById(int id);
        Task<int> CreateUser(User user);
        Task<int> UpdateUser(User user);
        Task<int> DeleteUser(int id);
    }
}
