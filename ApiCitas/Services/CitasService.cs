using ApiCitas.Data.Repositories;
using ApiCitas.Models;

namespace ApiCitas.Services
{
    public class CitasService : ICitasService
    {
        private readonly ICitasRepository _ICitasRepository;
        public CitasService(ICitasRepository citasRepository)
        {
            _ICitasRepository = citasRepository;
        }

        public async Task<int> CreateCitas(Cita citas)
        {
            return await _ICitasRepository.Create(citas);
        }

        public async Task<int> DeleteCitas(int id)
        {
            return await _ICitasRepository.Delete(id);
        }

        public async Task<IEnumerable<Cita>> GetAllCitas()
        {
            return await _ICitasRepository.GetAll();
        }

        public async Task<Cita> GetCitasById(int id)
        {
            return await _ICitasRepository.GetById(id);
        }

        public async Task<int> UpdateCitas(Cita citas)
        {
            return await _ICitasRepository.Update(citas);
        }
    }
}
