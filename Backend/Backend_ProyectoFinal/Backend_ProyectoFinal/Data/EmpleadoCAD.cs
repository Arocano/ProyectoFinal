using Backend_ProyectoFinal.Models;
using Microsoft.Data.SqlClient;

namespace Backend_ProyectoFinal.Data
{
    public class EmpleadoCAD
    {
        public static List<Empleado> ObtenerEmpleados()
        {
            List<Empleado> empleados = new List<Empleado>();
            try
            {
                Conexion con = new Conexion();
                string query = "SELECT * FROM EMPLEADOS;";
                SqlCommand comand = new SqlCommand(query, con.Conectar());
                SqlDataReader dr = comand.ExecuteReader();
                while (dr.Read())
                {
                    int id = Int16.Parse(dr["ID_EMP"].ToString());
                    string nombre = dr["NOM_EMP"].ToString();
                    string apellido = dr["APE_EMP"].ToString();
                    Departamento departamento = DepartamentoCAD.ObtenerDepartamento(
                        Int16.Parse(dr["ID_DEP_PER"].ToString()));
                    empleados.Add(new Empleado(departamento, id, nombre, apellido));
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
                Conexion con = new Conexion();
                string query = "SELECT * FROM EMPLEADOS WHERE ID_EMP = " + idEmpleado + ";";
                SqlCommand comand = new SqlCommand(query, con.Conectar());
                SqlDataReader dr = comand.ExecuteReader();
                Empleado empleado = null;
                while (dr.Read())
                {
                    int id = Int16.Parse(dr["ID_EMP"].ToString());
                    string nombre = dr["NOM_EMP"].ToString();
                    string apellido = dr["APE_EMP"].ToString();
                    Departamento departamento = DepartamentoCAD.ObtenerDepartamento(
                        Int16.Parse(dr["ID_DEP_PER"].ToString()));
                    empleado = new Empleado(departamento, id, nombre, apellido);
                }
                return empleado;
            }
            catch (Exception ex)
            {
                return null;
            }
        }

        public bool InsertarEmpleado(Empleado e)
        {
            return true;
        }

        public bool ModificarEmpleado(int idEmpleado)
        {
            return false;
        }

        public bool EliminarEmpleado(int idEmpleado)
        {
            return true;
        }
    }
}
