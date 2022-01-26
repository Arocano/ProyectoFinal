using Npgsql;

namespace BackendPostgres.Data
{
    public class Conexion
    {
        static NpgsqlConnection con = new NpgsqlConnection();

        static string servidor = "ec2-18-234-17-166.compute-1.amazonaws.com";
        static string bd = "dafglf3dst0epk";
        static string usuario = "oneyuguryozvdr";
        static string pass = "cad6ada832d6edbdf490aa1b1203a8e68b5ce70756dae237087294dbb161fe9c";
        static string puerto = "5432";

        static string cadenaConexion = "Server=" + servidor + ";" + "Port=" + puerto + ";" + "User Id=" + usuario + ";" + "Password=" + pass + ";" + "Database=" + bd + ";";

        public static NpgsqlConnection Conectar()
        {
            try
            {
                if (con.State == System.Data.ConnectionState.Closed)
                {
                    con.ConnectionString = cadenaConexion;
                    con.Open();
                }
            } catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return con;
        }
    }
}
