using Backend_ProyectoFinal.Models;
using Microsoft.Data.SqlClient;

namespace Backend_ProyectoFinal.Data
{
    public class ObservacionCAD
    {
        public static List<Observacion> ObtenerObservaciones(int idRegistro)
        {
            List<Observacion> observaciones = new List<Observacion>();
            try
            {
                Conexion con = new Conexion();
                string query = "SELECT * FROM OBSERVACIONES WHERE ID_REG_PER = " + idRegistro+";";
                SqlCommand comand = new SqlCommand(query, con.Conectar());
                SqlDataReader dr = comand.ExecuteReader();
                while (dr.Read())
                {
                    string descripcion = dr["DES_OBS"].ToString();
                    observaciones.Add(new Observacion(descripcion));
                }
                return observaciones;
            }
            catch (Exception ex)
            {
                return null;
            }
            
        }

        public bool InsertarObservacion(Observacion o)
        {
            return true;
        }

        public bool ModificarObservacion(Observacion o)
        {
            return true;
        }

        public bool EliminarObservacion(Observacion o)
        {
            return true;
        }
    }
}
