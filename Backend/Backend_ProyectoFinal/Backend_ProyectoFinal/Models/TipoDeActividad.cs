namespace Backend_ProyectoFinal.Models
{
    public class TipoDeActividad
    {
        private int idTipo;
        private string nombre;
        private string descripcion;

        public TipoDeActividad(int id, string nombre, string descripcion)
        {
            this.idTipo = id;
            this.nombre = nombre;
            this.descripcion = descripcion;
        }

        public TipoDeActividad()
        {
            this.idTipo = 0;
            this.nombre = "";
            this.descripcion = "";
        }

        public int IdTipo { get => idTipo; set => idTipo = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Descripcion { get => descripcion; set => descripcion = value; }
    }
}
