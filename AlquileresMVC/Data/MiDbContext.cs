using Microsoft.EntityFrameworkCore;
using AlquileresMVC.Models;

namespace AlquileresMVC.Data {
    public class MiDbContext : DbContext {
        public MiDbContext(DbContextOptions<MiDbContext> options) : base(options)
        {
        }

        public DbSet<Reserva> Reserva { get; set; }
        public DbSet<Usuario> Usuario {get; set;}
        public DbSet<MetodoPago> Metodo { get; set;}
        public DbSet<Vehiculo> Vehiculo {get; set;}
        public DbSet<Extra> Extra { get; set; }
        public DbSet<MetodoPago> MetodoPago { get; set; }
    }
}
