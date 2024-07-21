using AlquileresMVC.Models;

namespace AlquileresMVC.Repositories {
    
    public interface IReservaDAO
    {
        void InsertReserva(Reserva reserva);

        //void InsertUser(Usuario usuario); // ? 

        void InsertExtra(Extra extra);

        void InsertMetodoPago(MetodoPago metodo);

        void InsertVehiculo (Vehiculo vehiculo);

        Reserva GetReserva(int id);

        List<Extra> GetExtras (int id);

        List<Vehiculo> GetVehiculos(int id);

        List<MetodoPago> GetMetodos (int id);
    }
    
}