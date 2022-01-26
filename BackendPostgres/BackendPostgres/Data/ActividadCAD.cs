using BackendPostgres.Models;
using Npgsql;

namespace BackendPostgres.Data
{
    public class ActividadCAD
    {
        public static List<Actividad> ObtenerActividades()
        {
            List<Actividad> actividades = new List<Actividad>();
            try
            {
                string query = "SELECT * FROM ACTIVIDADES;";
                using (NpgsqlCommand cmd = new NpgsqlCommand(query, Conexion.Conectar()))
                {
                    NpgsqlDataReader dr = cmd.ExecuteReader();
                    while (dr.Read())
                    {
                        int idActividad = Int16.Parse(dr["ID_ACT"].ToString());
                        string nombre = dr["NOM_ACT"].ToString();
                        string descripcion = dr["DES_ACT"].ToString();
                        TipoDeActividad tipo = TipoDeActividadCAD.ObtenerTipo(
                            Int16.Parse(dr["TIP_ACT_PER"].ToString()));
                        actividades.Add(new Actividad(idActividad, nombre, descripcion, tipo));
                    }
                    return actividades;
                }
            }
            catch (Exception ex)
            {
                return null;
            }

        }
    }
}
