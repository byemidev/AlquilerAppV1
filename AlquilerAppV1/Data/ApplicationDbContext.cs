using AlquilerAppV1.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace AlquilerAppV1.Data
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<Pedido> Pedidos { get; set; }
        public DbSet<Vehiculo> Vehiculos { get; set; }
        public DbSet<Extra> Extras { get; set; }
        public DbSet<Marca> Marcas { get; set; }
        public DbSet<Modelo> Modelos { get; set; }




        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.Entity<Cliente>()
                .HasMany(c => c.Pedidos)
                .WithOne(p => p.Cliente)
                .HasForeignKey(p => p.ClienteId);

            builder.Entity<Vehiculo>()
                .HasMany(v => v.Pedidos)
                .WithOne(p => p.Vehiculo)
                .HasForeignKey(p => p.VehiculoId);

            builder.Entity<Marca>()
                .HasMany(b => b.Vehiculos)
                .WithOne(v => v.Marca)
                .HasForeignKey(v => v.VehiculoId);

            builder.Entity<Extra>()
                .HasMany(e => e.Vehiculos)
                .WithOne(v => v.Extra)
                .HasForeignKey(v => v.ExtraId);

            builder.Entity<Modelo>()
                .HasMany(m => m.Marcas)
                .WithOne(ma => ma.Modelo)
                .HasForeignKey(ma => ma.ModeloId);

        }
    }
}