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

        public static bool InsertarActividad(Actividad a)
        {
            try
            {
                Conexion con = new Conexion();
                string sql = "INSERT INTO ACTIVIDADES VALUES('"+a.Nombre+"','"+a.Descripcion+"',"+a.Tipo.IdTipo+");";
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

        public static bool ModificarActividad(int idActividad, Actividad a)
        {
            try
            {
                Conexion con = new Conexion();
                string sql = "UPDATE ACTIVIDADES SET NOM_ACT = '"+a.Nombre+"', DES_ACT = '"+a.Descripcion+"', " +
                    "TIP_ACT_PER = "+a.Tipo.IdTipo+" WHERE ID_ACT = "+idActividad+";";
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

        public static bool EliminarActividad(int idActividad)
        {
            try
            {
                Conexion con = new Conexion();
                string sql = "DELETE FROM ACTIVIDADES WHERE ID_ACT=" + idActividad + ";";
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
