using BackendPostgres.Models;
using Npgsql;

namespace BackendPostgres.Data
{
    public class EmpleadoCAD
    {
        public static List<Empleado> ObtenerEmpleados()
        {
            List<Empleado> empleados = new List<Empleado>();
            try
            {
                string sql = "SELECT * FROM EMPLEADOS;";
                using var cmd = new NpgsqlCommand(sql, Conexion.Conectar());
                using NpgsqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    int id = Int16.Parse(dr["ID_EMP"].ToString());
                    string nombre = dr["NOM_EMP"].ToString();
                    string apellido = dr["APE_EMP"].ToString();;
                    empleados.Add(new Empleado(id, nombre, apellido));
                }
                return empleados;
            }
            catch (Exception ex)
            {
                return null;
            }
        }

        public static Empleado ObtenerEmpleado(int idEmpleado)
        {
            try
            {
                string sql = "SELECT * FROM EMPLEADOS WHERE ID_EMP = " + idEmpleado + ";";
                using var cmd = new NpgsqlCommand(sql, Conexion.Conectar());
                using NpgsqlDataReader dr = cmd.ExecuteReader();
                Empleado empleado = null;
                while (dr.Read())
                {
                    int id = Int16.Parse(dr["ID_EMP"].ToString());
                    string nombre = dr["NOM_EMP"].ToString();
                    string apellido = dr["APE_EMP"].ToString();
                    empleado = new Empleado(id, nombre, apellido);
                }
                return empleado;
            }
            catch (Exception ex)
            {
                return null;
            }
        }
    }
}
