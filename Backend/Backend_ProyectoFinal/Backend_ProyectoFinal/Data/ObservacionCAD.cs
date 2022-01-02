using Backend_ProyectoFinal.Models;

namespace Backend_ProyectoFinal.Data
{
    public class ObservacionCAD
    {
        public List<Observacion> ObtenerObservaciones(int idRegistro)
        {
            List<Observacion> observaciones = new List<Observacion>();
            return observaciones;
        }

        public bool InsertarObservacion(Observacion o)
        {
            return true;
        }

        public bool ModificarObservacion(Observacion o)
        {
            return true;
        }

        public bool EliminarObservacion(Observacion o)
        {
            return true;
        }
    }
}
