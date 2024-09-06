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

        public Task<int> CreateCita(Cita cita)
        {
           return _citaRepository.Create(cita);
        }   

        public Task<int> DeleteCita(int id)
        {
            return _citaRepository.Delete(id);

        }

        public Task<IEnumerable<Cita>> GetAllCitas()
        {
            return _citaRepository.GetAll();
        }

        public Task<Cita> GetCitaById(int id)
        {
            return _citaRepository.GetById(id);
        }

        public Task<int> UpdateCita(Cita cita)
        {
            return _citaRepository.Update(cita);
        }


    }
}
