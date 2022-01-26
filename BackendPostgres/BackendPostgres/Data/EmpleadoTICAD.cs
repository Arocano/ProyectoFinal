using BackendPostgres.Models;
using Npgsql;

namespace BackendPostgres.Data
{
    public class EmpleadoTICAD
    {
        public static List<EmpleadoTI> ObtenerEmpleadosTI()
        {
            List<EmpleadoTI> empleados = new List<EmpleadoTI>();
            try
            {
                string sql = "SELECT * FROM USUARIOS WHERE TIP_USU = 'EmpleadoTI';";
                using var cmd = new NpgsqlCommand(sql, Conexion.Conectar());
                using NpgsqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    string usuario = dr["USU"].ToString();
                    string pass = dr["PAS"].ToString();
                    string nombre = dr["NOM_USU"].ToString();
                    string apellido = dr["APE_USU"].ToString();
                    string correo = dr["COR_USU"].ToString();
                    empleados.Add(new EmpleadoTI(usuario, pass, nombre, apellido, correo));
                }
                return empleados;
            }
            catch (Exception ex)
            {
                return null;
            }
        }

        public static EmpleadoTI ObtenerEmpleadoTI(string user)
        {
            try
            {
                string sql = "SELECT * FROM USUARIOS WHERE TIP_USU = 'EmpleadoTI'" +
                   "AND USU = '" + user + "';";
                using var cmd = new NpgsqlCommand(sql, Conexion.Conectar());
                using NpgsqlDataReader dr = cmd.ExecuteReader();
                EmpleadoTI e = null;
                while (dr.Read())
                {
                    string usuario = dr["USU"].ToString();
                    string pass = dr["PAS"].ToString();
                    string nombre = dr["NOM_USU"].ToString();
                    string apellido = dr["APE_USU"].ToString();
                    string correo = dr["COR_USU"].ToString();
                    e = new EmpleadoTI(usuario, pass, nombre, apellido, correo);
                }
                return e;
            }
            catch (Exception ex)
            {
                return null;
            }
        }

        public static bool InsertarEmpleadoTI(EmpleadoTI a)
        {
            string sql = "INSERT INTO USUARIOS (USU, PAS, NOM_USU, APE_USU, COR_USU, TIP_USU) " +
                "VALUES('" + a.User + "','" + a.Contrasenia + "','" + a.Nombre + "','" + a.Apellido + "','"
                + a.Correo + "','EmpleadoTI');";

            try
            {
                using var cmd = new NpgsqlCommand(sql, Conexion.Conectar());
                int filas = cmd.ExecuteNonQuery();
                if (filas == -1)
                {
                    return false;
                }
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public static bool ModificarContraseniaEmpleadoTI(string user, string contra)
        {
            string sql = "UPDATE USUARIOS SET PAS='" + contra + "' WHERE USU = '" + user + "';";
            try
            {
                using var cmd = new NpgsqlCommand(sql, Conexion.Conectar());
                int filas = cmd.ExecuteNonQuery();
                if (filas == -1)
                {
                    return false;
                }
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }
    }


}
