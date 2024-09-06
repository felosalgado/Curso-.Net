using ApiCitas.Data.Repositories;
using ApiCitas.Models;

namespace ApiCitas.Services
{
    public class CitaService : ICitaService
    {
        private readonly ICitaRepository _citaRepository;

        public CitaService(ICitaRepository citaRepository)
        {
            _citaRepository = citaRepository;
        }

        public async Task<IEnumerable<Citas>> GetAllCitas()
        {
            return await _citaRepository.GetAll();
        }

        public async Task<Citas> GetCitaById(int id)
        {
            return await _citaRepository.GetById(id);
        }

        public async Task<int> CreateCita(Citas cita)
        {
            return await _citaRepository.Create(cita);
        }

        public async Task<int> UpdateCita(Citas cita)
        {
            return await _citaRepository.Update(cita);
        }

        public async Task<int> DeleteCita(int id)
        {
            return await _citaRepository.Delete(id);
        }
    }
}
