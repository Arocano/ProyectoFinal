using Backend_ProyectoFinal.Models;

namespace Backend_ProyectoFinal.Data
{
    public class TipoDeActividadCAD
    {
        public List<TipoDeActividad> ObtenerTiposDeActividad()
        {
            List<TipoDeActividad> tipos = new List<TipoDeActividad>();
            return tipos;
        }

        public TipoDeActividad ObtenerTipoDeActividad(int idTipo)
        {
            TipoDeActividad tipo = new TipoDeActividad();
            return tipo;
        }

        public bool InsertarTipoDeActividad(TipoDeActividad t)
        {
            return true;
        }

        public bool ModificarTipoDeActividad(int idTipo)
        {
            return true;
        }

        public bool EliminarTipoDeActividad(int idTipo)
        {
            return true;
        }
    }
}
