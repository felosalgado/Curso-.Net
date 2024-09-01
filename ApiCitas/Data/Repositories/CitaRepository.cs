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
        public Task<int> Create(User cita)
        {
            using (var connection = _context.CreateConnection())
            {
                var query = "INSERT INTO Citas (CitasID, FechaCita, Descripcion, Lugar, Estado, FechaCreacion, FechaModificacion) VALUES (@UsuarioID, @FechaCita, @Descripcion, @Lugar, @Estado, @FechaCreacion, @FechaModificacion); SELECT CAST(SCOPE_IDENTITY() as int)";
                return await connection.QuerySingleAsync<int>(query, cita);
            }
        }

        public Task<int> Delete(int id)
        {
            using (var connection = _context.CreateConnection())
            {
                var query = "DELETE FROM Citas WHERE CitasID = @Id";
                return await connection.ExecuteAsync<int>(query, new { Id = id });   
            }
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
                var query = "SELECT * FROM Citas WHERE CitasID =@Id";
                return await connection.QueryAsync<Cita>(query, new { Id = id });
            }
        }

        public async Task<int> Update(User cita)
        {
            using (var connection = _context.CreateConnection())
            {
                var query = "UPDATE Citas SET UsuarioID = @UsuarioID, FechaCita = @FechaCita, Descripcion = @Descripcion, Lugar = @Lugar, Estado = @Estado, FechaCreacion = @FechaCreacion, FechaModificacion = @FechaModificacion   WHERE CitaID = @CitaID";
                return await connection.ExecuteAsync(query, cita);
            }
        }
    }
}
