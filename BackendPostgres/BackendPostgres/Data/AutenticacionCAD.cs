using BackendPostgres.Models;
using Npgsql;

namespace BackendPostgres.Data
{
    public class AutenticacionCAD
    {
        public static Usuario ObtenerUsuario(string user, string contra)
        {
            Usuario u = null;
            try
            {
                string sql = "SELECT * FROM USUARIOS WHERE " +
                    "USU = '" + user + "' AND PAS = '" + contra + "';";
                using var cmd = new NpgsqlCommand(sql, Conexion.Conectar());
                using NpgsqlDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    string usuario = dr["USU"].ToString();
                    string pass = dr["PAS"].ToString();
                    string nombre = dr["NOM_USU"].ToString();
                    string apellido = dr["APE_USU"].ToString();
                    string correo = dr["COR_USU"].ToString();
                    string tipo = dr["TIP_USU"].ToString();
                    u = new Usuario(usuario, pass, nombre, apellido, correo, tipo);
                }
                return u;
            }
            catch (Exception ex)
            {
                return u;
            }
        }

        public static Usuario ObtenerUsuario(string user)
        {
            Usuario u = null;
            try
            {
                string sql = "SELECT * FROM USUARIOS WHERE " +
                    "USU = '" + user + "';";
                using var cmd = new NpgsqlCommand(sql, Conexion.Conectar());
                using NpgsqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    string usuario = dr["USU"].ToString();
                    string pass = dr["PAS"].ToString();
                    string nombre = dr["NOM_USU"].ToString();
                    string apellido = dr["APE_USU"].ToString();
                    string correo = dr["COR_USU"].ToString();
                    string tipo = dr["TIP_USU"].ToString();
                    u = new Usuario(usuario, pass, nombre, apellido, correo, tipo);
                }
                return u;
            }
            catch (Exception ex)
            {
                return u;
            }
        }

        public static List<Usuario> ObtenerUsuarios()
        {
            List<Usuario> usuarios = new List<Usuario>();
            try
            {
                string sql = "SELECT * FROM USUARIOS;";
                using var cmd = new NpgsqlCommand(sql, Conexion.Conectar());
                using NpgsqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    string usuario = dr["USU"].ToString();
                    string pass = dr["PAS"].ToString();
                    string nombre = dr["NOM_USU"].ToString();
                    string apellido = dr["APE_USU"].ToString();
                    string correo = dr["COR_USU"].ToString();
                    string tipo = dr["TIP_USU"].ToString();
                    usuarios.Add(new Usuario(usuario, pass, nombre, apellido, correo, tipo));
                }
                return usuarios;
            }
            catch (Exception ex)
            {
                return null;
            }
        }
    }
}
