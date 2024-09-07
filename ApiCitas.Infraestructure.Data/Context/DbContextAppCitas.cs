using ApiCitas.Domain.Models;
using Microsoft.EntityFrameworkCore;
using System.Reflection.Emit;

namespace ApiCitas.Infraestructure.Data.Context
{
    public class DbContextAppCitas : DbContext
    {
        public DbContextAppCitas(DbContextOptions options) : base(options) { }
        public DbSet<Cita> Citas { get; set; }
        public DbSet<Usuario> Usuarios { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Cita>(entity =>
            {
                entity.HasKey(e => e.CitaID);
            });

            modelBuilder.Entity<Usuario>(entity =>
            {
                entity.HasKey(c => c.UsuarioID);
            });

            base.OnModelCreating(modelBuilder);
        }
    }
}
