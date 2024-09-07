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


        public async Task<IEnumerable<Cita>> GetAll()
        {
            using (var connection = _context.CreateConnection())
            {
                var query = "SELECT CitaID, UsuarioID, FechaCita, Descripcion, Lugar, Estado, FechaCreacion, FechaModificacion FROM Citas";
                return await connection.QueryAsync<Cita>(query);
            }
        }


        public async Task<int> Create(Cita cita)
        {
            using (var connection = _context.CreateConnection())
            {
                var parameters = new
                {
                    cita.UsuarioID,
                    cita.FechaCita,
                    cita.Descripcion,
                    cita.Lugar,
                    Est = cita.Estado.ToString(),
                    cita.FechaModificacion,
                    cita.CitaID
                };
                var query = "INSERT INTO Citas (UsuarioID, FechaCita, Descripcion, Lugar, Estado) " +
                            "VALUES (@UsuarioID, @FechaCita, @Descripcion, @Lugar, @Est); SELECT CAST(SCOPE_IDENTITY() as int)";
                return await connection.QuerySingleAsync<int>(query, parameters);
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



        public async Task<Cita> GetById(int id)
        {
            using (var connection = _context.CreateConnection())
            {
                var query = "SELECT CitaID, UsuarioID, FechaCita, Descripcion, Lugar, Estado, FechaCreacion, FechaModificacion " +
                            "FROM Citas WHERE CitaID = @id";
                return await connection.QuerySingleOrDefaultAsync<Cita>(query, new { id = id });
            }
        }



        public async Task<int> Update(Cita cita)
        {
            DateTime fechaActual = DateTime.Now;

            using (var connection = _context.CreateConnection())
            {
                var parameters = new
                {
                    cita.UsuarioID,
                    cita.FechaCita,
                    cita.Descripcion,
                    cita.Lugar,
                    Est = cita.Estado.ToString(),
                    FechaModificacion = fechaActual,
                    cita.CitaID
                };
                var query = "UPDATE Citas SET " +
                    "UsuarioID = @UsuarioID, " +
                    "FechaCita = @FechaCita, " +
                    "Descripcion = @Descripcion, " +
                    "Lugar = @Lugar, " +
                    "Estado = @Est, " +
                    "FechaModificacion = @FechaModificacion " +
                    "WHERE CitaID = @CitaID"; 
                return await connection.ExecuteAsync(query, parameters);
            }
        }


    }
}
