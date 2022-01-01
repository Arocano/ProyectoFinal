namespace Backend_ProyectoFinal.Models
{
    public class Observacion
    {
        private Registro registro;
        private string descripcion;

        public Observacion(Registro registro, string descripcion)
        {
            this.Registro = registro;
            this.Descripcion = descripcion;
        }

        public Registro Registro { get => registro; set => registro = value; }
        public string Descripcion { get => descripcion; set => descripcion = value; }
    }
}
