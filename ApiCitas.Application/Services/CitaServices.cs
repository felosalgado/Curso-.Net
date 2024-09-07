using ApiCitas.Application.Contracts;
using ApiCitas.Domain.Contracts;
using ApiCitas.Domain.Models;

namespace ApiCitas.Application.Services
{
    public class CitaServices : ICitaServices
    {
        private readonly ICitaRepository _citaRepository;

        public CitaServices(ICitaRepository citaRepository)
        {
            _citaRepository = citaRepository;
        }

        public async Task<IEnumerable<Cita>> GetAllCitas()
        {
            try
            {
                return await _citaRepository.GetAll();
            }
            catch (Exception ex)
            {
                string message = ex.Message;
                // Algun control con el error, como un log o algo y una respuesta diferente dependiendo de los errores
                return new List<Cita>();
            }
        }

        public async Task<Cita> GetCitaById(int id)
        {
            try
            {
                return await _citaRepository.GetById(id);
            }
            catch (Exception ex)
            {
                string message = ex.Message;
                // Algun control con el error, como un log o algo
                return new Cita();
            }
        }

        public async Task<Cita> CreateCita(Cita cita)
        {
            try
            {
                return await _citaRepository.Create(cita);
            }
            catch (Exception ex)
            {
                string message = ex.Message;
                // Algun control con el error, como un log o algo
                return new Cita();
            }
        }

        public async Task<Cita> UpdateCita(Cita cita)
        {
            try
            {
                return await _citaRepository.Update(cita);
            }
            catch (Exception ex)
            {
                string message = ex.Message;
                // Algun control con el error, como un log o algo
                return new Cita();
            }
        }

        public async Task<Cita> DeleteCita(int id)
        {
            try
            {
                return await _citaRepository.Delete(id);
            }
            catch (Exception ex)
            {
                string message = ex.Message;
                // Algun control con el error, como un log o algo
                return new Cita();
            }
            
        }
    }
}
