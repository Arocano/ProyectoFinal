namespace Backend_ProyectoFinal.Models
{
    public class Observacion
    {
        private string descripcion;

        public Observacion(string descripcion)
        {
            this.Descripcion = descripcion;
        }

        public Observacion()
        {
        }

        public string Descripcion { get => descripcion; set => descripcion = value; }
    }
}
