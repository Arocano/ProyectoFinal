namespace BackendPostgres.Models
{
    public class Empleado
    {
        private int idEmpleado;
        private string nombre;
        private string apellido;

        public int IdEmpleado { get => idEmpleado; set => idEmpleado = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Apellido { get => apellido; set => apellido = value; }

        public Empleado(int idEmpleado, string nombre, string apellido)
        {
            this.IdEmpleado = idEmpleado;
            this.Nombre = nombre;
            this.Apellido = apellido;
        }

        public Empleado()
        {
        }
    }
}
