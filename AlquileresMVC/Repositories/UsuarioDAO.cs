using AlquileresMVC.Data;
using AlquileresMVC.Models;

namespace AlquileresMVC.Repositories
{
    public class UsuarioDAO : IUsuarioDAO
    {
        
        public readonly MiDbContext _context;

        public UsuarioDAO (MiDbContext contexto){
            _context = contexto;
        }

        public void InsertUsuario(Usuario usuario){
            _context.Usuario.Add(usuario);
            _context.SaveChanges();
        }

        public void InsertReserva(Reserva reserva){
            _context.Reserva.Add(reserva);
            _context.SaveChanges();
        }

        public  List<Reserva> GetReservas(int id) { 
            return _context.Reserva.Where(e => e.Id == id).ToList();
        }
    }
}