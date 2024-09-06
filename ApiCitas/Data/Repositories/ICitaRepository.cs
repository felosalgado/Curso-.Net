using ApiCitas.Models;

namespace ApiCitas.Data.Repositories;
/// <summary>
/// 
/// </summary>
public interface ICitaRepository
{
    /// <summary>
    /// 
    /// </summary>
    /// <returns></returns>
    Task<IEnumerable<Cita>> GetAll();
    /// <summary>
    /// 
    /// </summary>
    /// <param name="id"></param>
    /// <returns></returns>
    Task<Cita> GetById(int id);
    /// <summary>
    /// 
    /// </summary>
    /// <param name="cita"></param>
    /// <returns></returns>
    Task<int> Create(Cita cita);
    /// <summary>
    /// 
    /// </summary>
    /// <param name="cita"></param>
    /// <returns></returns>
    Task<int> Update(Cita cita);
    /// <summary>
    /// 
    /// </summary>
    /// <param name="id"></param>
    /// <returns></returns>
    Task<int> Delete(int id);
    
}
