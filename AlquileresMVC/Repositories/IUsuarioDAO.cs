using AlquileresMVC.Models;

namespace AlquileresMVC.Repositories
{
    public interface IUsuarioDAO {
        void InsertUsuario(Usuario usuario);
        void InsertReserva(Reserva reserva);
        List<Reserva> GetReservas(int id);
    } //doing: necesito que el comportamiento de la web determine el DAO, no se si IUsuarioDAO es necesario 
}