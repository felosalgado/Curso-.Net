using ApiCitas.Models;
using Dapper;
using System.Collections.Generic;
using System.Data;
using System.Threading.Tasks;

namespace ApiCitas.Data.Repositories
{
    public class UserRepository : IUserRepository
    {
        private readonly IDbContext _context;
        public UserRepository(IDbContext context) 
        {
            _context = context;
        }

        public async Task<IEnumerable<User>> GetAll()
        {
            using (var connection = _context.CreateConnection())
            {
                var query = "SELECT * FROM Users";
                return await connection.QueryAsync<User>(query);
            }
        }

        public async Task<User> GetById(int id)
        {
            using (var connection = _context.CreateConnection())
            {
                var query = "SELECT * FROM Users WHERE Id = @Id";
                return await connection.QuerySingleOrDefaultAsync<User>(query, new { Id = id });
            }
        }

        public async Task<int> Create(User user)
        {
            using (var connection = _context.CreateConnection())
            {
                var query = "INSERT INTO Users (Name, Email, Password) VALUES (@Name, @Email, @Password); SELECT CAST(SCOPE_IDENTITY() as int)";
                return await connection.QuerySingleAsync<int>(query, user);
            }
        }

        public async Task<int> Update(User user)
        {
            using (var connection = _context.CreateConnection())
            {
                var query = "UPDATE Users SET Name = @Name, Email = @Email, Password = @Password WHERE Id = @Id";
                return await connection.ExecuteAsync(query, user);
            }
        }

        public async Task<int> Delete(int id)
        {
            using (var connection = _context.CreateConnection())
            {
                var query = "DELETE FROM Users WHERE Id = @Id";
                return await connection.ExecuteAsync(query, new { Id = id });
            }
        }

       
    }
}
