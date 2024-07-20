namespace AlquileresMVC.Data {
    public class MiDbContext : DbContext {
        public MiDbContext(DbContextOptions<MiDbContext> options) : base(options)
        {
        }

        public DbSet<Reserva> Reserva { get; set; }
        public DbSet<Usuario> Usuario {get; set;}
        public Dbset<MetodoPago> Metodo { get; set;}
        public Dbset<Vehiculo> Vehiculo {get; set;}
        public DbSet<Extra> Extra { get; set; }
    }
}
