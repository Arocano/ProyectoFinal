using Backend_ProyectoFinal.Models;
using Microsoft.Data.SqlClient;

namespace Backend_ProyectoFinal.Data
{
    public class DepartamentoCAD
    {
        public static List<Departamento> ObtenerDepartamentos()
        {
            List<Departamento> departamentos = new List<Departamento>();
            try
            {
                Conexion con = new Conexion();
                string query = "SELECT * FROM DEPARTAMENTOS;";
                SqlCommand comand = new SqlCommand(query, con.Conectar());
                SqlDataReader dr = comand.ExecuteReader();
                while (dr.Read())
                {
                    int id = Int16.Parse(dr["ID_DEP"].ToString());
                    string nombre = dr["NOM_DEP"].ToString();
                    string descripcion = dr["DES_DEP"].ToString();
                    departamentos.Add(new Departamento(id,nombre,descripcion));
                }
                return departamentos;
            }
            catch (Exception ex)
            {
                return null;
            }
        }

        public static Departamento ObtenerDepartamento(int idDepartamento)
        {
            try
            {
                Conexion con = new Conexion();
                string query = "SELECT * FROM DEPARTAMENTOS WHERE ID_DEP = "+idDepartamento+";";
                SqlCommand comand = new SqlCommand(query, con.Conectar());
                SqlDataReader dr = comand.ExecuteReader();
                Departamento d = null;
                while (dr.Read())
                {
                    int id = Int16.Parse(dr["ID_DEP"].ToString());
                    string nombre = dr["NOM_DEP"].ToString();
                    string descripcion = dr["DES_DEP"].ToString();
                    d = new Departamento(id, nombre, descripcion);
                }
                return d;
            }
            catch (Exception ex)
            {
                return null;
            }
        }

        public bool InsertarDepartamento(Departamento d)
        {
            return false;
        }

        public bool ModificarDepartamento(int idDepartamento)
        {
            return true;
        }

        public bool EliminarDepartamento(int idDepartamento)
        {
            return true;
        }
    }
}
