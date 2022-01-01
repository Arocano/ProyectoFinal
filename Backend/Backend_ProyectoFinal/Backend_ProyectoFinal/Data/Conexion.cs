using Microsoft.Data.SqlClient;

namespace Backend_ProyectoFinal.Data
{
    public class Conexion
    {
        SqlConnection con;

        public Conexion()
        {
            SqlConnectionStringBuilder builder = new SqlConnectionStringBuilder();
            builder.DataSource = "proyecto-final-4sw.database.windows.net";
            builder.UserID = "administrador";
            builder.Password = "ProyectoFinal4sw";
            builder.InitialCatalog = "PROYECTOFINAL4SW";
            con = new SqlConnection(builder.ConnectionString);
        }

        public SqlConnection Conectar()
        {
            try
            {
                con.Open();
                return con;
            }
            catch (Exception ex)
            {
                return null;
            }
        }

        public bool Desconectar()
        {
            try
            {
                con.Close();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }
    }
}
