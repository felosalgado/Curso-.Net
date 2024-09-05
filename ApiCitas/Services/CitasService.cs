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

        public async Task<int> CreateCitas(Citas citas)
        {
            return await _ICitasRepository.Create(citas);
        }

        public async Task<int> DeleteCitas(int id)
        {
            return await _ICitasRepository.Delete(id);
        }

        public async Task<IEnumerable<Citas>> GetAllCitas()
        {
            return await _ICitasRepository.GetAll();
        }

        public async Task<Citas> GetCitasById(int id)
        {
            return await GetCitasById(id);
        }

        public async Task<int> UpdateCitas(Citas citas)
        {
            return await UpdateCitas(citas);
        }
    }
}
