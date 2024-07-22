using AlquileresMVC.Models.Admin;

namespace AlquileresMVC.Repositories
{
    public interface IUsuarioDAO {
        void InsertUsuario(Usuario usuario);
        void InsertReserva(Reserva reserva);
        List<Reserva> GetReservas(int id);
    }
}