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
                    int id = Int16.Parse(dr["ID_USU"].ToString());
                    string usuario = dr["USU"].ToString();
                    string pass = dr["PAS"].ToString();
                    string nombre = dr["NOM_USU"].ToString();
                    string apellido = dr["APE_USU"].ToString();
                    string correo = dr["COR_USU"].ToString();
                    empleados.Add(new EmpleadoTI(id, usuario, pass, nombre, apellido, correo));
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
                    int id = Int16.Parse(dr["ID_USU"].ToString());
                    string usuario = dr["USU"].ToString();
                    string pass = dr["PAS"].ToString();
                    string nombre = dr["NOM_USU"].ToString();
                    string apellido = dr["APE_USU"].ToString();
                    string correo = dr["COR_USU"].ToString();
                    e = new EmpleadoTI(id,usuario,pass,nombre,apellido,correo);
                }
                return e;
            }
            catch (Exception ex)
            {
                return null;
            }
        }

        public static EmpleadoTI ObtenerEmpleadoTI(int idEmpleado)
        {
            try
            {
                Conexion con = new Conexion();
                string query = "SELECT * FROM USUARIOS WHERE TIP_USU = 'EmpleadoTI'" +
                    "AND  ID_USU = " + idEmpleado + ";";
                SqlCommand comand = new SqlCommand(query, con.Conectar());
                SqlDataReader dr = comand.ExecuteReader();
                EmpleadoTI e = null;
                while (dr.Read())
                {
                    int id = Int16.Parse(dr["ID_USU"].ToString());
                    string usuario = dr["USU"].ToString();
                    string pass = dr["PAS"].ToString();
                    string nombre = dr["NOM_USU"].ToString();
                    string apellido = dr["APE_USU"].ToString();
                    string correo = dr["COR_USU"].ToString();
                    e = new EmpleadoTI(id, usuario, pass, nombre, apellido, correo);
                }
                return e;
            }
            catch (Exception ex)
            {
                return null;
            }
        }
    }
}
