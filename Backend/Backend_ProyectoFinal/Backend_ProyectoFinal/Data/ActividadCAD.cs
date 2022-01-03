using Backend_ProyectoFinal.Models;
using Microsoft.Data.SqlClient;

namespace Backend_ProyectoFinal.Data
{
    public class ActividadCAD
    {
        public static List<Actividad> ObtenerActividades()
        {
            List<Actividad> actividades = new List<Actividad>();
            try
            {
                Conexion con = new Conexion();
                string query = "SELECT * FROM ACTIVIDADES;";
                SqlCommand comand = new SqlCommand(query, con.Conectar());
                SqlDataReader dr = comand.ExecuteReader();
                while (dr.Read())
                {
                    int idActividad = Int16.Parse(dr["ID_ACT"].ToString());
                    string nombre = dr["NOM_ACT"].ToString();
                    string descripcion = dr["DES_ACT"].ToString();
                    TipoDeActividad tipo = TipoDeActividadCAD.ObtenerTipoDeActividad(
                        Int16.Parse(dr["TIP_ACT_PER"].ToString()));
                    actividades.Add(new Actividad(idActividad, nombre, descripcion, tipo));
                }
                return actividades;
            }
            catch (Exception ex)
            {
                return null;
            }
            
        }

        public static Actividad ObtenerActividad(int idActividad)
        {
            try
            {
                Conexion con = new Conexion();
                string query = "SELECT * FROM ACTIVIDADES WHERE ID_ACT = "+idActividad+";";
                SqlCommand comand = new SqlCommand(query, con.Conectar());
                SqlDataReader dr = comand.ExecuteReader();
                Actividad a = null;
                while (dr.Read())
                {
                    int id = Int16.Parse(dr["ID_ACT"].ToString());
                    string nombre = dr["NOM_ACT"].ToString();
                    string descripcion = dr["DES_ACT"].ToString();
                    TipoDeActividad tipo = TipoDeActividadCAD.ObtenerTipoDeActividad(
                        Int16.Parse(dr["TIP_ACT_PER"].ToString()));
                    a = new Actividad(id, nombre, descripcion, tipo);
                }
                return a;
            }
            catch (Exception ex)
            {
                return null;
            }
        }

        public bool InsertarActividad(Actividad a)
        {
            return true;
        }

        public bool ModificarActividad(int idActividad)
        {
            return true;
        }

        public bool EliminarActividad(int idActividad)
        {
            return true;
        }
    }
}
