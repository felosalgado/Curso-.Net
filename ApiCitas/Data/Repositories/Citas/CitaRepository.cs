using ApiCitas.Models;
using Dapper;

namespace ApiCitas.Data.Repositories.Citas
{
    public class CitaRepository : ICitaRepository
    {
        private readonly IDbContext _context;

        public CitaRepository(IDbContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Cita>> GetAll()
        {
            using (var connection = _context.CreateConnection())
            {
                var query = "SELECT * FROM Citas";
                return await connection.QueryAsync<Cita>(query);
            }
        }

        public async Task<Cita> GetById(int id)
        {
            using (var connection = _context.CreateConnection())
            {
                var query = "SELECT * FROM Citas WHERE CitaID = @Id";
                return await connection.QuerySingleOrDefaultAsync<Cita>(query, new { Id = id });
            }
        }

        public async Task<int> Create(Cita cita)
        {
            using (var connection = _context.CreateConnection())
            {
                var query = @"INSERT INTO Citas 
                              (UsuarioID, FechaCita, Descripcion, Lugar, Estado) 
                              VALUES 
                              (@UsuarioID, @FechaCita, @Descripcion, @Lugar, @Estado); 
                              SELECT CAST(SCOPE_IDENTITY() as int)";
                return await connection.QuerySingleAsync<int>(query, cita);
            }
        }

        public async Task<int> Update(Cita cita)
        {
            using (var connection = _context.CreateConnection())
            {
                var query = @"UPDATE Citas SET 
                              UsuarioID = @UsuarioID, 
                              FechaCita = @FechaCita, 
                              Descripcion = @Descripcion, 
                              Lugar = @Lugar, 
                              Estado = @Estado, 
                              FechaModificacion = GETDATE()
                              WHERE CitaID = @CitaID";
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
