namespace Backend_ProyectoFinal.Models
{
    public class Empleado
    {
        private Departamento departamento;
        private int idEmpleado;
        private string nombre;
        private string apellido;

        public Empleado(Departamento departamento, int idEmpleado, string nombre, string apellido)
        {
            this.departamento = departamento;
            this.idEmpleado = idEmpleado;
            this.nombre = nombre;
            this.apellido = apellido;
        }

        public Empleado()
        {
        }
    }
}
