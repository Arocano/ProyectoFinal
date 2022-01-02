namespace Backend_ProyectoFinal.Models
{
    public class Actividad
    {
        private int idActividad;
        private string nombre;
        private string descripcion;
        private TipoDeActividad tipo;

        public Actividad(int idActividad, string nombre, string descripcion, TipoDeActividad tipo)
        {
            this.IdActividad = idActividad;
            this.Nombre = nombre;
            this.Descripcion = descripcion;
            this.Tipo = tipo;
        }

        public Actividad()
        {
        }

        public int IdActividad { get => idActividad; set => idActividad = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Descripcion { get => descripcion; set => descripcion = value; }
        public TipoDeActividad Tipo { get => tipo; set => tipo = value; }
    }
}
