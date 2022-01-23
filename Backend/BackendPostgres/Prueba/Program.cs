using Npgsql;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prueba
{
    internal class Program
    {
        static void Main(string[] args)
        {
             NpgsqlConnection con = new NpgsqlConnection();

             string servidor = "ec2-3-232-22-121.compute-1.amazonaws.com";
             string bd = "d1tf2tr44q0fpb";
             string usuario = "rwngxneoqgmgaq";
             string pass = "5195cd5406ded605df4e4bc5e1c806350f281f822854c6cf2a93fc9ee8e3db5f";
             string puerto = "5432";

             string cadenaConexion = "Server=" + servidor + ";" + "Port=" + puerto + ";" + "User Id=" + usuario + ";" + "Password=" + pass + ";" + "Database=" + bd + ";";


                try
                {
                    con.ConnectionString = cadenaConexion;
                    con.Open();
                    Console.WriteLine("Conectado");
                    Console.ReadLine();
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                Console.ReadLine();
            }
            
        }
    }
}
