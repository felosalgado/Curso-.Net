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
                var query = "SELECT * FROM Citas WHERE CitaID = @CitaID";
                return await connection.QuerySingleOrDefaultAsync<Citas>(query, new { CitaID = id });
            }
        }

        public async Task<int> Create(Citas cita)
        {
            using (var connection = _context.CreateConnection())
            {
                var query = @"INSERT INTO Citas (UsuarioID, FechaCita, Descripcion, Lugar, Estado, FechaCreacion) 
                          VALUES (@UsuarioID, @FechaCita, @Descripcion, @Lugar, @Estado, GETDATE());
                          SELECT CAST(SCOPE_IDENTITY() as int)";
                return await connection.QuerySingleAsync<int>(query, cita);
            }
        }

        public async Task<int> Update(Citas cita)
        {
            using (var connection = _context.CreateConnection())
            {
                var query = @"UPDATE Citas 
                          SET UsuarioID = @UsuarioID, FechaCita = @FechaCita, Descripcion = @Descripcion, 
                              Lugar = @Lugar, Estado = @Estado, FechaModificacion = GETDATE() 
                          WHERE CitaID = @CitaID";
                return await connection.ExecuteAsync(query, cita);
            }
        }

        public async Task<int> Delete(int id)
        {
            using (var connection = _context.CreateConnection())
            {
                var query = "DELETE FROM Citas WHERE CitaID = @CitaID";
                return await connection.ExecuteAsync(query, new { CitaID = id });
            }
        }
    }
}
