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

        public List<Registro> ObtenerRegistros(string fechaInicio, string fechaFinal)
        {
            List<Registro> registros = new List<Registro>();
            return registros;
        }

        public List<Registro> ObtenerRegistros(string estado)
        {
            List<Registro> registros = new List<Registro>();
            return registros;
        }

        public List<Registro> ObtenerRegistros(EmpleadoTI e)
        {
            List<Registro> registros = new List<Registro>();
            return registros;
        }

        public Registro ObtenerRegistro(int idRegistro)
        {
            Registro registro = new Registro();
            return registro;
        }

        public bool ModificarRegistro(int idRegistro)
        {
            return false;
        }

        public bool EliminarRegistro(int idRegistro)
        {
            return true;
        }
    }
}
