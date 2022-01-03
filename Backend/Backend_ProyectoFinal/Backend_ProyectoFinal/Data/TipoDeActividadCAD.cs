using Backend_ProyectoFinal.Models;
using Microsoft.Data.SqlClient;

namespace Backend_ProyectoFinal.Data
{
    public class TipoDeActividadCAD
    {
        public static List<TipoDeActividad> ObtenerTiposDeActividad()
        {
            List<TipoDeActividad> tipos = new List<TipoDeActividad>();
            try
            {
                Conexion con = new Conexion();
                string query = "SELECT * FROM TIPOS_DE_ACTIVIDAD;";
                SqlCommand comand = new SqlCommand(query, con.Conectar());
                SqlDataReader dr = comand.ExecuteReader();
                while (dr.Read())
                {
                    int id = Int16.Parse(dr["ID_TIP"].ToString());
                    string nombre = dr["NOM_TIP"].ToString();
                    string descripcion = dr["DES_TIP"].ToString();
                    tipos.Add(new TipoDeActividad(id, nombre, descripcion));
                }
                return tipos;
            }
            catch (Exception ex)
            {
                return null;
            }
        }

        public static TipoDeActividad ObtenerTipoDeActividad(int idTipo)
        {
            TipoDeActividad tipo = new TipoDeActividad();
            try
            {
                Conexion con = new Conexion();
                string query = "SELECT * FROM TIPOS_DE_ACTIVIDAD WHERE ID_TIP="+idTipo+";";
                SqlCommand comand = new SqlCommand(query, con.Conectar());
                SqlDataReader dr = comand.ExecuteReader();
                TipoDeActividad t = null;
                while (dr.Read())
                {
                    int id = Int16.Parse(dr["ID_TIP"].ToString());
                    string nombre = dr["NOM_TIP"].ToString();
                    string descripcion = dr["DES_TIP"].ToString();
                    t = new TipoDeActividad(id, nombre, descripcion);
                }
                return t;
            }
            catch (Exception ex)
            {
                return null;
            }
            return tipo;
        }

        public bool InsertarTipoDeActividad(TipoDeActividad t)
        {
            return true;
        }

        public bool ModificarTipoDeActividad(int idTipo)
        {
            return true;
        }

        public bool EliminarTipoDeActividad(int idTipo)
        {
            return true;
        }
    }
}
