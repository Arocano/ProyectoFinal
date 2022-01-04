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

        public static bool InsertarEmpleado(Empleado e)
        {
            try
            {
                Conexion con = new Conexion();
                string sql = "INSERT INTO EMPLEADOS VALUES('" + e.Nombre + "','" + e.Apellido + "','" + e.Departamento.IdDepartamento + "');";
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

        public static bool ModificarEmpleado(int idEmpleado, Empleado e)
        {
            try
            {
                Conexion con = new Conexion();
                string sql = "UPDATE EMPLEADOS SET NOM_EMP='" + e.Nombre + "', APE_EMP='" + e.Apellido + "', " +
                    "ID_DEP_PER = " + e.Departamento.IdDepartamento + " WHERE ID_EMP = " + idEmpleado + ";"; 
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

        public static bool EliminarEmpleado(int idEmpleado)
        {
            try
            {
                Conexion con = new Conexion();
                string sql = "DELETE FROM EMPLEADOS WHERE ID_EMP='" + idEmpleado + "';";
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
