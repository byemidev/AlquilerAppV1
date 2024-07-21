using AlquileresMVC.Models;
using AlquileresMVC.Data;

namespace AlquileresMVC.Repositories {

    public class ReservaDAO : IReservaDAO {

        private readonly MiDbContext _context;

        public ReservaDAO (MiDbContext contexto){
            _context = contexto;
        }

        public void InsertReserva(Reserva reserva)
        {
            _context.Reserva.Add(reserva);
            _context.SaveChanges();
        }

        

        public void InsertExtra(Extra extra)
        {
            _context.Extra.Add(extra);
            _context.SaveChanges();
        }


        //insert all objects in reserva

        public void InsertVehiculo(Vehiculo vehiculo)
        {
            _context.Vehiculo.Add(vehiculo);
            _context.SaveChanges();
        }

        public void InsertMetodoPago (MetodoPago metodo){
            _context.MetodoPago.Add(metodo);
            _context.SaveChanges();
        }
        

        public Reserva GetReserva(int id)
        {
            return _context.Reserva.Find(id);
        }

        public List<Extra> GetExtras(int id){
            return _context.Extra.Where(e => e.reservaId == id).ToList();
        }

        public List<Vehiculo> GetVehiculos(int id){
            return _context.Vehiculo.Where(e => e.reservaId == id).ToList();
        }
        
        public List<MetodoPago> GetMetodos(int id){
            return _context.MetodoPago.Where(e => e.reservaId == id).ToList();
        }

    }
}

