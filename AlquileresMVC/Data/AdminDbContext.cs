using AlquileresMVC.Models.Admin;
using Microsoft.EntityFrameworkCore;

namespace AlquileresMVC.Data
{

    // Dependencias de paquetes instalados:

    /*Microsoft.EntityFrameworkCore (8.0.7)
    Microsoft.EntityFrameworkCore.SqlServer (8.0.7)
    Microsoft.EntityFrameworkCore.Tools (8.0.7)
    Microsoft.EntityFrameworkCore.Design (8.0.7)
     */


    public class AdminDbContext : DbContext
    {

        public DbSet<Reserva> Reservas { get; set; }
        public DbSet<ReservaExtras> ReservaExtras { get; set; }
        public DbSet<Extra> Extras { get; set; }
        public DbSet<MetodoPago> FormasDePago { get; set; }
        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<Vehiculo> Vehiculos { get; set; }

        public AdminDbContext(DbContextOptions<AdminDbContext> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Para que la tabla intermedia tenga doble primary key
            modelBuilder.Entity<ReservaExtras>()
                .HasKey(re => new { re.FKreservaId, re.FKextraId });

            // Relaciones de reserva
            modelBuilder.Entity<Reserva>()
                .HasOne(r => r.usuario)
                .WithMany()
                .HasForeignKey(r => r.FKusuarioId);

            modelBuilder.Entity<Reserva>()
                .HasOne(r => r.vehiculo)
                .WithMany()
                .HasForeignKey(r => r.FKvehiculoId);

            modelBuilder.Entity<Reserva>()
                .HasMany(r => r.ExtrasReserva)
                .WithOne(re => re.reserva)
                .HasForeignKey(re => re.FKreservaId);

            // Relacion de extras con la tabla intermedia
            modelBuilder.Entity<Extra>()
                .HasMany(e => e.OrderExtras)
                .WithOne(re => re.extra)
                .HasForeignKey(re => re.FKextraId);

            // Relacion de forma de pago con reserva
            modelBuilder.Entity<MetodoPago>()
                .HasOne<Reserva>()
                .WithMany()
                .HasForeignKey(f => f.reservaId);

        }

    }
}
