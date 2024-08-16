using System.Data;

namespace ApiCitas.Data
{
    public interface IDbContext
    {
        IDbConnection CreateConnection();
    }
}
