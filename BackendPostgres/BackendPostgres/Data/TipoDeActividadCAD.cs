using BackendPostgres.Models;
using Npgsql;

namespace BackendPostgres.Data
{
    public class TipoDeActividadCAD
    {
        public static List<TipoDeActividad> ObtenerTipos()
        {
            try
            {
                List<TipoDeActividad> lista = new List<TipoDeActividad>();
                string sql = "SELECT * FROM TIPOS_DE_ACTIVIDAD;";
                using var cmd = new NpgsqlCommand(sql, Conexion.Conectar());
                using NpgsqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    int id = dr.GetInt32(0);
                    string nombre = dr.GetString(1);
                    string desc = dr.GetString(2);
                    lista.Add(new TipoDeActividad(id, nombre, desc));
                }
                return lista;
            } catch (Exception ex)
            {
                return null;
            }

        }

        public static TipoDeActividad ObtenerTipo(int idTipo)
        {
            try
            {
                TipoDeActividad t = null;
                Conexion con = new Conexion();
                string query = "SELECT * FROM TIPOS_DE_ACTIVIDAD WHERE ID_TIP=" + idTipo + ";";
                using (NpgsqlCommand comando = new NpgsqlCommand(query, Conexion.Conectar()))
                {
                    using (NpgsqlDataReader dr = comando.ExecuteReader())
                    {

                        while (dr.Read())
                        {
                            int id = Int16.Parse(dr["ID_TIP"].ToString());
                            string nombre = dr["NOM_TIP"].ToString();
                            string descripcion = dr["DES_TIP"].ToString();
                            t = new TipoDeActividad(id, nombre, descripcion);
                        }

                    }
                    return t;
                }
            }
            catch (Exception ex)
            {
                return null;
            }

        }
    }
}
