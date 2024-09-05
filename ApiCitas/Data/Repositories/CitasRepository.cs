using ApiCitas.Models;
using Dapper;

namespace ApiCitas.Data.Repositories
{
    public class CitasRepository : ICitasRepository
    {
        private readonly IDbContext _context;

        public CitasRepository(IDbContext context)
        {
            _context = context;
        }

        public async Task<int> Create(Citas citas)
        {
            using (var connection = _context.CreateConnection())
            {
                var query = $@"INSERT INTO Cita (UsuarioID,
                        FechaCita,
                        Descripcion,
                        Lugar,
                        Estado,
                        FechaCreacion,
                        FechaModificacion
                        ) 
                    VALUES (@UsuarioID,
                        @FechaCita,
                        @Descripcion,
                        @Lugar,
                        @Estado,
                        @FechaCreacion,
                        @FechaModificacion
                        );
                SELECT CAST(SCOPE_IDENTITY() as int)";
                return await connection.QuerySingleAsync<int>(query, citas);
            }
        }

        public async Task<int> Delete(int id)
        {
            using (var connection = _context.CreateConnection())
            {
                var query = "DELETE FROM Cita WHERE CitaID = @CitaID";
                return await connection.ExecuteAsync(query, new { CitaID = id });
            }
        }

        public async Task<IEnumerable<Citas>> GetAll()
        {
            using(var connection = _context.CreateConnection())
            {
                var query = "SELECT * FROM Cita";
                return await connection.QueryAsync<Citas>(query);
            }
        }

        public async Task<Citas> GetById(int id)
        {
            using( var connection = _context.CreateConnection())
            {
                var query = "SELECT * FROM Cita WHERE CitaID = @CitaID";
                return await connection.QuerySingleOrDefaultAsync<Citas>(query, new { CitaID = id});
            }
        }

        public async Task<int> Update(Citas citas)
        {
            using(var connection = _context.CreateConnection())
            {
                var query = "UPDATE Cita SET " +
                    "UsuarioID = @UsuarioID, " +
                    "FechaCita = @FechaCita, " +
                    "Descripcion = @Descripcion, " +
                    "Lugar = @Lugar, " +
                    "Estado = @Estado, " +
                    "FechaModificacion = @FechaModificacion  " +
                    "WHERE CitaID = @CitaID";
                return await connection.ExecuteAsync(query, citas);
            }
        }
    }
}
