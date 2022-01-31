using BackendPostgres.Models;
using Npgsql;

namespace BackendPostgres.Data
{
    public class RegistroCAD
    {
        public static bool InsertarRegistro(Registro r)
        {
            string sql = "INSERT INTO REGISTROS (EST_REG, FEC_REG, HOR_REG, ID_ACT_REG, ID_USU_REG, ID_EMP_REG, OBS_REG) VALUES ('" + r.Estado + "','" + r.Fecha + "','" + r.Horas + "'," +
            r.Actividad.IdActividad + ",'" + r.EmpleadoTI.User + "'," + r.Empleado.IdEmpleado + ",'" + r.Observaciones + "');";
            
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

        public static bool InsertarRegistro(RegistroV3 r)
        {
            string sql = "INSERT INTO REGISTROS (EST_REG, FEC_REG, HOR_REG, ID_ACT_REG, ID_USU_REG, ID_EMP_REG, OBS_REG) " +
                "VALUES ('" + r.Estado + "','"+r.Fecha+"','"+r.Horas+"',"+r.Actividad+",'"+r.Usuario+"',"+r.Empleado+",'"+r.Observaciones+"');";

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

        public static List<RegistroV2> ObtenerRegistros()
        {
            List<RegistroV2> registros = new List<RegistroV2>();
            try
            {
                string sql = "SELECT R.ID_REG, R.EST_REG, R.FEC_REG, A.NOM_ACT, R.HOR_REG, U.NOM_USU, U.APE_USU, E.NOM_EMP, E.APE_EMP, R.OBS_REG FROM REGISTROS R, EMPLEADOS E, USUARIOS U, ACTIVIDADES A WHERE A.ID_ACT = R.ID_ACT_REG AND U.USU = R.ID_USU_REG AND E.ID_EMP = R.ID_EMP_REG ORDER BY R.FEC_REG DESC;";
                using var cmd = new NpgsqlCommand(sql, Conexion.Conectar());
                using NpgsqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    int id = Convert.ToInt32(dr["ID_REG"]);
                    string estado = dr["EST_REG"].ToString();
                    string fecha = dr["FEC_REG"].ToString();
                    string actividad = dr["NOM_ACT"].ToString();
                    string horas = dr["HOR_REG"].ToString();
                    string usuario = dr["NOM_USU"].ToString() + " " + dr["APE_USU"].ToString();
                    string empleado = dr["NOM_EMP"].ToString() + " " + dr["APE_EMP"].ToString();
                    string observaciones = dr["OBS_REG"].ToString();
                    registros.Add(new RegistroV2(id, estado, fecha, actividad, horas, usuario, empleado, observaciones));
                }
                return registros;
            }
            catch (Exception ex)
            {
                return null;
            }
        }
    }
}
