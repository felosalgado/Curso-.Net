using ApiCitas.Models;
using System.Runtime.CompilerServices;

namespace ApiCitas.Services
{
    public class CitaService : ICitaService
    {
        private readonly ICitaService _repository;
        public CitaService(ICitaService repository)
        {
            _repository = repository;
        }

        public async Task<int> CreateCita(Cita cita)
        {
            return await _repository.CreateCita(cita);
        }

        public async Task<int> DeleteCita(int id)
        {
            return await _repository.DeleteCita(id);
        }

        public async Task<IEnumerable<Cita>> GetAllCitas()
        {
            return await _repository.GetAllCitas();
        }

        public async Task<Cita> GetCitaById(int id)
        {
            return await _repository.GetCitaById(id);
        }

        public async Task<int> UpdateCita(Cita cita)
        {
            return await _repository.UpdateCita (cita);
        }
    }
}
