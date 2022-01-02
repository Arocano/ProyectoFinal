using Backend_ProyectoFinal.Models;

namespace Backend_ProyectoFinal.Data
{
    public class ActividadCAD
    {
        public List<Actividad> ObtenerActividades()
        {
            List<Actividad> actividades = new List<Actividad>();
            return actividades;
        }

        public Actividad ObtenerActividad(int idActividad)
        {
            Actividad a = new Actividad();
            return a;
        }

        public bool InsertarActividad(Actividad a)
        {
            return true;
        }

        public bool ModificarActividad(int idActividad)
        {
            return true;
        }

        public bool EliminarActividad(int idActividad)
        {
            return true;
        }
    }
}
