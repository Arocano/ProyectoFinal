using Backend_ProyectoFinal.Models;
using Microsoft.Data.SqlClient;

namespace Backend_ProyectoFinal.Data
{
    public class RegistroCAD
    {
        public static List<Registro> ObtenerRegistros()
        {
            List<Registro> registros = new List<Registro>();
            try
            {
                Conexion con = new Conexion();
                string query = "SELECT * FROM REGISTROS;";
                SqlCommand comand = new SqlCommand(query, con.Conectar());
                SqlDataReader dr = comand.ExecuteReader();
                while (dr.Read())
                {
                    int id = Int16.Parse(dr["ID_REG"].ToString());
                    string estado = dr["EST_REG"].ToString();
                    string fecha = dr["FEC_REG"].ToString();
                    string horas = dr["HOR_REG"].ToString();
                    Actividad actividad = ActividadCAD.ObtenerActividad(
                        Int16.Parse(dr["ID_ACT_REG"].ToString()));
                    EmpleadoTI empleadoTI = EmpleadoTICAD.ObtenerEmpleadoTI(
                        Int16.Parse(dr["ID_USU_REG"].ToString()));
                    Empleado empleado = EmpleadoCAD.ObtenerEmpleado(
                        Int16.Parse(dr["ID_EMP_REG"].ToString()));
                    List<Observacion> observaciones = ObservacionCAD.ObtenerObservaciones(id);
                    registros.Add(new Registro(id,estado,fecha,horas,actividad,empleadoTI,empleado,observaciones));
                }
                return registros;
            }
            catch (Exception ex)
            {
                return null;
            }
            return registros;
        }

        public static List<Registro> ObtenerRegistros(string fechaInicio, string fechaFinal)
        {
            List<Registro> registros = new List<Registro>();
            try
            {
                Conexion con = new Conexion();
                string query = "SELECT * FROM REGISTROS WHERE FEC_REG BETWEEN '"+fechaInicio+"' AND '" + fechaFinal+"';";
                SqlCommand comand = new SqlCommand(query, con.Conectar());
                SqlDataReader dr = comand.ExecuteReader();
                while (dr.Read())
                {
                    int id = Int16.Parse(dr["ID_REG"].ToString());
                    string estado = dr["EST_REG"].ToString();
                    string fecha = dr["FEC_REG"].ToString();
                    string horas = dr["HOR_REG"].ToString();
                    Actividad actividad = ActividadCAD.ObtenerActividad(
                        Int16.Parse(dr["ID_ACT_REG"].ToString()));
                    EmpleadoTI empleadoTI = EmpleadoTICAD.ObtenerEmpleadoTI(
                        Int16.Parse(dr["ID_USU_REG"].ToString()));
                    Empleado empleado = EmpleadoCAD.ObtenerEmpleado(
                        Int16.Parse(dr["ID_EMP_REG"].ToString()));
                    List<Observacion> observaciones = ObservacionCAD.ObtenerObservaciones(id);
                    registros.Add(new Registro(id, estado, fecha, horas, actividad, empleadoTI, empleado, observaciones));
                }
                return registros;
            }
            catch (Exception ex)
            {
                return null;
            }
            return registros;
        }

        public Registro ObtenerRegistro(int idRegistro)
        {
            Registro registro = new Registro();
            return registro;
        }

        public static bool InsertarRegistro(Registro r)
        {
            try
            {
                Conexion con = new Conexion();
                string sql = "INSERT INTO REGISTROS VALUES ('" + r.Estado + "','" + r.Fecha + "','" + r.Horas + "'," +
                    r.Actividad.IdActividad + "," + r.EmpleadoTI.IdUsuario + "," + r.Empleado.IdEmpleado + ");";
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

        public static bool ModificarRegistro(int idRegistro, Registro r)
        {
            try
            {
                Conexion con = new Conexion();
                string sql = "UPDATE REGISTROS SET EST_REG = '"+r.Estado+"', ID_ACT_REG = "+r.Actividad.IdActividad+
                    ", ID_EMP_REG = " + r.Empleado.IdEmpleado+";";
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

        public static bool EliminarRegistro(int idRegistro)
        {
            try
            {
                Conexion con = new Conexion();
                string sql = "DELETE FROM REGISTROS WHERE ID_REG=" + idRegistro + ";";
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
