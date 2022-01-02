using Backend_ProyectoFinal.Models;

namespace Backend_ProyectoFinal.Data
{
    public class UsuarioCAD
    {
        public List<Usuario> ObtenerUsuarios()
        {
            List<Usuario> usuarios = new List<Usuario>();
            return usuarios;
        }

        public Usuario ObtenerUsuario(string usuario)
        {
            Usuario u = new Usuario();
            return u;
        }

        public bool InsertarUsuario(Usuario u)
        {
            return true;
        }

        public bool ModificarUsuario(int idUsuario)
        {
            return true;
        }

        public bool EliminarUsuario(int idUsuario)
        {
            return true;
        }
    }
}
