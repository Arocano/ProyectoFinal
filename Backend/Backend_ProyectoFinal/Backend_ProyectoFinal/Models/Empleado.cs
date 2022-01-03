namespace Backend_ProyectoFinal.Models
{
    public class Empleado
    {
        private Departamento departamento;
        private int idEmpleado;
        private string nombre;
        private string apellido;

        public Departamento Departamento { get => departamento; set => departamento = value; }
        public int IdEmpleado { get => idEmpleado; set => idEmpleado = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Apellido { get => apellido; set => apellido = value; }

        public Empleado(Departamento departamento, int idEmpleado, string nombre, string apellido)
        {
            this.Departamento = departamento;
            this.IdEmpleado = idEmpleado;
            this.Nombre = nombre;
            this.Apellido = apellido;
        }

        public Empleado()
        {
        }
    }
}
