using AlquileresMVC.Models.Admin;
using AlquileresMVC.Data;

namespace AlquileresMVC.Repositories
{
    public class IndexDAO : IIndexDAO
    {
        private readonly AdminDbContext _context;
        public IndexDAO(AdminDbContext context) { 
            _context = context;
        }

        public List<Extra> GetExtras()
        {
            return _context.Extras.ToList();
        }

        public List<MetodoPago> GetMetodos()
        {
            return _context.FormasDePago.ToList();
        }

        public List<Vehiculo> GetVehiculos()
        {
            return _context.Vehiculos.ToList();
        }
    }
}
