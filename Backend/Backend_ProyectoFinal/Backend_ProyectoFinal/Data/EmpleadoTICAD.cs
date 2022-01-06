using Backend_ProyectoFinal.Models;
using Microsoft.Data.SqlClient;

namespace Backend_ProyectoFinal.Data
{
    public class EmpleadoTICAD
    {
        public static List<EmpleadoTI> ObtenerEmpleadosTI()
        {
            List<EmpleadoTI> empleados = new List<EmpleadoTI>();
            try
            {
                Conexion con = new Conexion();
                string query = "SELECT * FROM USUARIOS WHERE TIP_USU = 'EmpleadoTI';";
                SqlCommand comand = new SqlCommand(query, con.Conectar());
                SqlDataReader dr = comand.ExecuteReader();
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
                Conexion con = new Conexion();
                string query = "SELECT * FROM USUARIOS WHERE TIP_USU = 'EmpleadoTI'" +
                    "AND USU = '" + user + "';";
                SqlCommand comand = new SqlCommand(query, con.Conectar());
                SqlDataReader dr = comand.ExecuteReader();
                EmpleadoTI e = null;
                while (dr.Read())
                {
                    string usuario = dr["USU"].ToString();
                    string pass = dr["PAS"].ToString();
                    string nombre = dr["NOM_USU"].ToString();
                    string apellido = dr["APE_USU"].ToString();
                    string correo = dr["COR_USU"].ToString();
                    e = new EmpleadoTI(usuario,pass,nombre,apellido,correo);
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
            try
            {
                Conexion con = new Conexion();
                string sql = "INSERT INTO USUARIOS VALUES('" + a.User + "','" + a.Contrasenia + "','" + a.Nombre + "','" + a.Apellido + "','"
                    + a.Correo + "','EmpleadoTI');";
                SqlCommand comand = new SqlCommand(sql, con.Conectar());
                int filasAfectadas = comand.ExecuteNonQuery();
                if (filasAfectadas == 1)
                {
                    con.Desconectar();
                    return true;
                }
                else
                {
                    con.Desconectar();
                    return false;
                }

            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public static bool ModificarContraseniaEmpleadoTI(string user, EmpleadoTI a)
        {
            try
            {
                Conexion con = new Conexion();
                string sql = "UPDATE USUARIOS SET PAS='" + a.Contrasenia + "' WHERE USU = '" + user + "';";
                SqlCommand comand = new SqlCommand(sql, con.Conectar());
                int filasAfectadas = comand.ExecuteNonQuery();
                if (filasAfectadas == 1)
                {
                    con.Desconectar();
                    return true;
                }
                else
                {
                    con.Desconectar();
                    return false;
                }

            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public static bool EliminarEmpleadoTI(string user)
        {
            try
            {
                Conexion con = new Conexion();
                string sql = "DELETE FROM USUARIOS WHERE USU='" + user + "' AND " +
                    "TIP_USU = 'EmpleadoTI';";
                SqlCommand comand = new SqlCommand(sql, con.Conectar());
                int filasAfectadas = comand.ExecuteNonQuery();
                if (filasAfectadas == 1)
                {
                    con.Desconectar();
                    return true;
                }
                else
                {
                    con.Desconectar();
                    return false;
                }

            }
            catch (Exception ex)
            {
                return false;
            }
        }
    }
}
