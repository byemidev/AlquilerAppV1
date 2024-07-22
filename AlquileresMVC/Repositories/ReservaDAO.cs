using AlquileresMVC.Models.Admin;
using AlquileresMVC.Data;
using Microsoft.EntityFrameworkCore;

namespace AlquileresMVC.Repositories {

    public class ReservaDAO : IReservaDAO {

        private readonly AdminDbContext _context;

        public ReservaDAO (AdminDbContext contexto){
            _context = contexto;
        }

        public void InsertReserva(Reserva reserva)
        {
            _context.Reservas.Add(reserva);
            _context.SaveChanges();
        }

        public void InsertReservasExtras(ReservaExtras reservaExtras) { 
            _context.ReservaExtras.Add(reservaExtras);  
            _context.SaveChanges();
        }

        

        public void InsertExtra(Extra extra)
        {
            _context.Extras.Add(extra);
            _context.SaveChanges();
        }


        //insert all objects in reserva

        public void InsertVehiculo(Vehiculo vehiculo)
        {
            _context.Vehiculos.Add(vehiculo);
            _context.SaveChanges();
        }

        public void InsertMetodoPago (MetodoPago metodo){
            _context.FormasDePago.Add(metodo);
            _context.SaveChanges();
        }
        

        public Reserva GetReserva(int id)
        {
            return _context.Reservas.Find(id);
        }

        public List<Extra> GetExtras(int reservaId)
        {
            // Use Include to eager load related ReservaExtras and Extra entities
            return _context.Reservas
                .Include(r => r.ExtrasReserva)
                .ThenInclude(re => re.extra)
                .Where(r => r.Id == reservaId)
                .SelectMany(r => r.ExtrasReserva)
                .Select(re => re.extra)
                .ToList();
        }

        public List<MetodoPago> GetMetodos(int reservaId)
        {
            // Use _context explicitly to emphasize DbContext usage
            return _context.Reservas
                .Include(r => r.metodo)
                .Where(r => r.Id == reservaId)
                .Select(r => r.metodo)
                .ToList();
        }

        public List<Vehiculo> GetVehiculos(int reservaId)  
        {
            // Use Include to eager load related Reserva entity
            return _context.Reservas
                .Include(r => r.vehiculo)  // Include the Vehiculo entity
                .Where(r => r.Id == reservaId) // Filter by reservation ID
                .Select(r => r.vehiculo)  // Select only the Vehiculo object
                .ToList();
        }



    }
}

