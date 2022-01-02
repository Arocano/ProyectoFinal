using Backend_ProyectoFinal.Models;

namespace Backend_ProyectoFinal.Data
{
    public class EmpleadoCAD
    {
        public List<Empleado> ObtenerEmpleados()
        {
            List<Empleado> empleados = new List<Empleado>();
            return empleados;
        }

        public Empleado ObtenerEmpleado(int idEmpleado)
        {
            return new Empleado();  
        }

        public bool InsertarEmpleado(Empleado e)
        {
            return true;
        }

        public bool ModificarEmpleado(int idEmpleado)
        {
            return false;
        }

        public bool EliminarEmpleado(int idEmpleado)
        {
            return true;
        }
    }
}
