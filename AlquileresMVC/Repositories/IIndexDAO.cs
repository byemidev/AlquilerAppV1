using AlquileresMVC.Models.Admin;

namespace AlquileresMVC.Repositories
{
    public interface IIndexDAO
    {

        List<Vehiculo> GetVehiculos();
        List<MetodoPago> GetMetodos();

        List<Extra> GetExtras();
        
    }
}
