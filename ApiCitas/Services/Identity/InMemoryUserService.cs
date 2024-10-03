using ApiCitas.Models;
using ApiCitas.Models.Identity;

namespace ApiCitas.Services.Identity
{
    public class InMemoryUserService
    {
        private readonly List<UserIdentity> _users = new()
    {
        new UserIdentity { Username = "user", Password = "password", SubjectId = "1" }
    };

        public Task<UserIdentity> GetUser(string username, string password)
        {
            return Task.FromResult(_users.FirstOrDefault(u => u.Username == username && u.Password == password));
        }
    }
}
