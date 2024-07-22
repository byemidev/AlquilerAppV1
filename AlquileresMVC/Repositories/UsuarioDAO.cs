using AlquileresMVC.Data;
using AlquileresMVC.Models.Admin;

namespace AlquileresMVC.Repositories
{
    public class UsuarioDAO : IUsuarioDAO
    {
        
        public readonly AdminDbContext _context;

        public UsuarioDAO (AdminDbContext contexto){
            _context = contexto;
        }

        public void InsertUsuario(Usuario usuario){
            _context.Usuarios.Add(usuario);
            _context.SaveChanges();
        }

        public void InsertReserva(Reserva reserva){
            _context.Reservas.Add(reserva);
            _context.SaveChanges();
        }

        public  List<Reserva> GetReservas(int id) { 
            return _context.Reservas.Where(e => e.Id == id).ToList();
        }
    }
}