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
            return _context.Rerserva.Find(id);
        }

        public List<Extra> GetExtras(int id){
            return _context.Extra.Where(e => e.ReservaId == id).ToList();
        }

        public List<Vehiculo> GetVehiculos(){
            return _context.Extra.Where(e => e.ReservaId == id).ToList();
        }
        
        public List<Vehiculo> GetMetodos(){
            return _context.Extra.Where(e => e.ReservaId == id).ToList();
        }

    }
}

