using ApiCitas.Data.Repositories.Interfaces;
using ApiCitas.Models;
using Dapper;

namespace ApiCitas.Data.Repositories
{
    public class CitaRepository : ICitaRepository
    {
        private readonly IDbContext _context;
        public CitaRepository(IDbContext context)
        {
            _context = context;
        }
        public async Task<int> Add(Cita cita)
        {
            using (var connection = _context.CreateConnection())
            {
                var query = "INSERT INTO Citas (UsuarioID, FechaCita, Descripcion, Lugar, Estado, FechaCreacion, FechaModificacion) VALUES (@UsuarioID, @FechaCita, @Descripcion, @Lugar, @Estado, @FechaCreacion, @FechaModificacion); SELECT CAST(SCOPE_IDENTITY() as int)";
                return await connection.QuerySingleAsync<int>(query, cita);
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

        public async Task<Cita?> Get(int id)
        {
            using (var connection = _context.CreateConnection())
            {
                var query = "SELECT * FROM Citas WHERE CitaID = @Id";
                return await connection.QuerySingleOrDefaultAsync<Cita>(query, new { Id = id });
            }
        }

        public async Task<IEnumerable<Cita>> Get()
        {
            using (var connection = _context.CreateConnection())
            {
                var query = "SELECT * FROM Citas";
                return await connection.QueryAsync<Cita>(query);
            }
        }

        public async Task<int> Update(Cita cita)
        {
            using (var connection = _context.CreateConnection())
            {
                var query = "INSERT INTO Citas (UsuarioID, FechaCita, Descripcion, Lugar, Estado, FechaCreacion, FechaModificacion) VALUES (@UsuarioID, @FechaCita, @Descripcion, @Lugar, @Estado, @FechaCreacion, @FechaModificacion); SELECT CAST(SCOPE_IDENTITY() as int)";
                return await connection.QuerySingleAsync<int>(query, cita);
            }
        }
    }
}
