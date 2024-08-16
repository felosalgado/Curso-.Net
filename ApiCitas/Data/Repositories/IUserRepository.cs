using ApiCitas.Models;

namespace ApiCitas.Data.Repositories
{
    public interface IUserRepository
    {
        Task<User> GetById(int id);
        Task<int> Create(User user);
        Task<int> Update(User user);
        Task<int> Delete(int id);
        Task<IEnumerable<User>> GetAll();
    }
}
