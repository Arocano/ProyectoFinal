using Backend_ProyectoFinal.Models;
using Microsoft.Data.SqlClient;

namespace Backend_ProyectoFinal.Data
{
    public class AutenticacionCAD
    {
        //INICIO DE SESIÓN
        public static Usuario Login(string user, string contra)
        {
            Usuario u = new Usuario();
            try
            {
                Conexion con = new Conexion();
                string query = "SELECT * FROM USUARIOS WHERE " +
                    "USU = '" + user + "' AND PAS = '" + contra + "';";
                SqlCommand comand = new SqlCommand(query, con.Conectar());
                SqlDataReader dr = comand.ExecuteReader();
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
                return null;
            }
        }
    }
}
