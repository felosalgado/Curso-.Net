using ApiCitas.Data.Repositories;
using ApiCitas.Data.Repositories.Interfaces;
using ApiCitas.Models;
using ApiCitas.Services.Interfaces;

namespace ApiCitas.Services
{
    public class CitaService:ICitaService
    {
        private readonly ICitaRepository _repository;

        public CitaService(ICitaRepository repository)
        {
            _repository = repository;
        }

        public async Task<IEnumerable<Cita>> GetAllCitas()
        {
            return await _repository.Get();
        }

        public async Task<Cita?> GetCitaById(int id)
        {
            return await _repository.Get(id);
        }

        public async Task<int> CreateCita(Cita cita)
        {
            return await _repository.Add(cita);
        }

        public async Task<int> UpdateCita(Cita cita)
        {
            return await _repository.Update(cita);
        }

        public async Task<int> DeleteCita(int id)
        {
            return await _repository.Delete(id);
        }
    }
}
