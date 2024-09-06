using ApiCitas.Models;

namespace ApiCitas.Services;

public interface ICitaService
{
    /// <summary>
    /// 
    /// </summary>
    /// <returns></returns>
    Task<IEnumerable<Cita>> GetAllCitas();

    /// <summary>
    /// 
    /// </summary>
    /// <param name="id"></param>
    /// <returns></returns>
    Task<Cita> GetCitaById(int id);

    /// <summary>
    /// 
    /// </summary>
    /// <param name="cita"></param>
    /// <returns></returns>
    Task<int> CreateCita(Cita cita);

    /// <summary>
    /// 
    /// </summary>
    /// <param name="cita"></param>
    /// <returns></returns>
    Task<int> UpdateCita(Cita cita);
    
    /// <summary>
    /// 
    /// </summary>
    /// <param name="id"></param>
    /// <returns></returns>
    Task<int> DeleteCita(int id);
}
