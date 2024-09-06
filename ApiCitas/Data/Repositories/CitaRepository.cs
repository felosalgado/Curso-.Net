using ApiCitas.Models;
using Dapper;
using System.Collections.Generic;
using System.Data;
using System.Threading.Tasks;

namespace ApiCitas.Data.Repositories
{
    public class CitaRepository : ICitaRepository
    {
        private readonly IDbContext _context;
        public CitaRepository(IDbContext context) 
        {
            _context = context;
        }

        public async Task<IEnumerable<Citas>> GetAll()
        {
            using (var connection = _context.CreateConnection())
            {
                var query = "SELECT * FROM Citas";
                return await connection.QueryAsync<Citas>(query);
            }
        }

        public async Task<Citas> GetById(int id)
        {
            using (var connection = _context.CreateConnection())
            {
                var query = "SELECT * FROM Citas WHERE CitaID = @Id";
                return await connection.QuerySingleOrDefaultAsync<Citas>(query, new { Id = id });
            }
        }

        public async Task<int> Create(Citas cita)
        {
            using (var connection = _context.CreateConnection())
            {
                var query = "INSERT INTO Citas (UsuarioID, FechaCita, Descripcion, Lugar, Estado, FechaCreacion, FechaModificacion) VALUES (@UsuarioID, @FechaCita, @Descripcion, @Lugar, @Estado, @FechaCreacion, @FechaModificacion); SELECT CAST(SCOPE_IDENTITY() as int)";
                return await connection.QuerySingleAsync<int>(query, cita);
            }
        }

        public async Task<int> Update(Citas cita)
        {
            using (var connection = _context.CreateConnection())
            {
                var query = "UPDATE Citas SET UsuarioID = @UsuarioID, FechaCita = @FechaCita, Descripcion = @Descripcion, Lugar = @Lugar, Estado = @Estado, FechaCreacion = @FechaCreacion, FechaModificacion = @FechaModificacion   WHERE CitaID = @CitaID";
                return await connection.ExecuteAsync(query, cita);
            }
        }

        public async Task<int> Delete(int id)
        {
            using (var connection = _context.CreateConnection())
            {
                var query = "DELETE FROM Citas WHERE CitaID = @Id";
                return await connection.ExecuteAsync(query, new { Id = id });
            }
        }

       
    }
}
