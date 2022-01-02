using Backend_ProyectoFinal.Models;

namespace Backend_ProyectoFinal.Data
{
    public class RegistroCAD
    {
        public List<Registro> ObtenerRegistros()
        {
            List<Registro> registros = new List<Registro>();
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
