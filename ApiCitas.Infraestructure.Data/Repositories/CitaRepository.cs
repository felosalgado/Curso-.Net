using ApiCitas.Domain.Contracts;
using ApiCitas.Domain.Models;
using ApiCitas.Infraestructure.Data.Context;
using Microsoft.EntityFrameworkCore;

namespace ApiCitas.Infraestructure.Data.Repositories
{
    public class CitaRepository : ICitaRepository
    {
        private readonly DbContextAppCitas _context;
        public CitaRepository(DbContextAppCitas context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Cita>> GetAll()
        {
            return await _context.Citas.ToListAsync();
        }

        public async Task<Cita> GetById(int CitaID)
        {
            return _context.Citas.Where(x => x.CitaID == CitaID).FirstOrDefault();
        }

        public async Task<Cita> Create(Cita cita)
        {
            _context.Citas.Add(cita);
            _context.SaveChanges();
            return cita;
        }

        public async Task<Cita> Update(Cita cita)
        {
            Cita updateCita = _context.Citas.Where(x => x.CitaID == cita.CitaID).FirstOrDefault();
            if (updateCita != null)
            {
                updateCita.Lugar = cita.Lugar;
                updateCita.Descripcion = cita.Descripcion;
                updateCita.Estado = cita.Estado;
                updateCita.FechaCita = cita.FechaCita;
                updateCita.FechaCreacion = cita.FechaCreacion;
                updateCita.FechaModificacion = cita.FechaModificacion;
                updateCita.UsuarioID = cita.UsuarioID;

                _context.Citas.Update(updateCita);
                _context.SaveChanges();
            }
            else
            {
                updateCita = new Cita();
            }

            return updateCita;
        }

        public async Task<Cita> Delete(int CitaID)
        {
            Cita deleteCita = _context.Citas.Where(x => x.CitaID == CitaID).FirstOrDefault();
            if (deleteCita != null)
            {
                _context.Citas.Remove(deleteCita);
                _context.SaveChanges();
            }
            else
            {
                deleteCita = new Cita();
            }
            return deleteCita;
        }
    }
}
