using ApiCitas.Data.Repositories;
using ApiCitas.Models;

namespace ApiCitas.Services
{
    public class CitaService:ICitaService
    {
        private readonly ICitaRepository _repository;
        public CitaService(ICitaRepository repository)
        {
            _repository = repository; 
        }
        public async Task<int> CreateCita(Cita cita)
        {
            return await _repository.Create(cita);
        }

        public async Task<int> DeleteCita(int id)
        {
            return await _repository.Delete(id);
        }

        public async Task<IEnumerable<Cita>> GetAllCita()
        {
            return await _repository.GetAll();
        }

        public async Task<Cita> GetCitaById(int id)
        {
            return await _repository.GetById(id);
        }

        public async Task<int> UpdateCita(Cita cita)
        {
            return await _repository.Update(cita);
        }
    }
}
