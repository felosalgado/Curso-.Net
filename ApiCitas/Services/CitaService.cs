using ApiCitas.Data.Repositories;
using ApiCitas.Models;

namespace ApiCitas.Services;

/// <summary>
/// 
/// </summary>
public class CitaService : ICitaService
{
    private readonly ICitaRepository _citaRepository;

    /// <summary>
    /// 
    /// </summary>
    /// <param name="citaRepository"></param>
    public CitaService(ICitaRepository citaRepository)
    {
        _citaRepository = citaRepository;
    }

    /// <summary>
    /// 
    /// </summary>
    /// <returns></returns>
    public async Task<IEnumerable<Cita>> GetAllCitas()
    {
        return await _citaRepository.GetAll();
    }

    /// <summary>
    /// 
    /// </summary>
    /// <param name="id"></param>
    /// <returns></returns>
    public async Task<Cita> GetCitaById(int id)
    {
        return await _citaRepository.GetById(id);
    }

    /// <summary>
    /// 
    /// </summary>
    /// <param name="cita"></param>
    /// <returns></returns>
    public async Task<int> CreateCita(Cita cita)
    {
        return await _citaRepository.Create(cita);
    }

    /// <summary>
    /// 
    /// </summary>
    /// <param name="cita"></param>
    /// <returns></returns>
    public async Task<int> UpdateCita(Cita cita)
    {
        return await _citaRepository.Update(cita);
    }

    /// <summary>
    /// 
    /// </summary>
    /// <param name="id"></param>
    /// <returns></returns>
    public async Task<int> DeleteCita(int id)
    {
        return await _citaRepository.Delete(id);
    }
}
