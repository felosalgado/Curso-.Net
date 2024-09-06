using ApiCitas.Data.Repositories.Citas;
using ApiCitas.Models;

namespace ApiCitas.Services.Citas
{
    public class CitaService : ICitaService
    {
        private readonly ICitaRepository _citaRepository;

        public CitaService(ICitaRepository citaRepository)
        {
            _citaRepository = citaRepository;
        }

        public async Task<IEnumerable<Cita>> GetAllCitas()
        {
            return await _citaRepository.GetAll();
        }

        public async Task<Cita> GetCitaById(int id)
        {
            return await _citaRepository.GetById(id);
        }

        public async Task<int> CreateCita(Cita cita)
        {
            return await _citaRepository.Create(cita);
        }

        public async Task<int> UpdateCita(Cita cita)
        {
            return await _citaRepository.Update(cita);
        }

        public async Task<int> DeleteCita(int id)
        {
            return await _citaRepository.Delete(id);
        }
    }
}
