using ApiCitas.Data.Repositories;
using ApiCitas.Models;

namespace ApiCitas.Services
{
    public class CitasService : ICitasService
    {
        private readonly ICitasRepository _citasRepository;

        public CitasService(ICitasRepository citasRepository)
        {
            _citasRepository = citasRepository;
        }



        public async Task<int> CreateCita(Cita cita)
        {
            return await _citasRepository.Create(cita);
        }


        public async Task<int> DeleteCita(int id)
        {
            return await _citasRepository.Delete(id);
        }


        public async Task<IEnumerable<Cita>> GetAllCitas()
        {
            return await _citasRepository.GetAll();
        }


        public async Task<Cita> GetCitaById(int id)
        {
            return await _citasRepository.GetById(id);
        }


        public async Task<int> UpdateCita(Cita cita)
        {
            return await _citasRepository.Update(cita);
        }
    }
}
