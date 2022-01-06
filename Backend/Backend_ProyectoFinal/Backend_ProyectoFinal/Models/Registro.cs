using Backend_ProyectoFinal.Data;

namespace Backend_ProyectoFinal.Models
{
    public class Registro
    {
        private int idRegistro;
        private string estado;
        private string fecha;
        private string horas;
        private Actividad actividad;
        private EmpleadoTI empleadoTI;
        private Empleado empleado;
        private string observaciones;

        public Registro(int idRegistro, string estado, string fecha, string horas, Actividad actividad, EmpleadoTI empleadoTI, Empleado empleado, 
            string observaciones)
        {
            this.idRegistro = idRegistro;
            this.estado = estado;
            this.fecha = fecha;
            this.horas = horas;
            this.actividad = actividad;
            this.empleadoTI = empleadoTI;
            this.empleado = empleado;
            this.observaciones = observaciones;
        }

        public Registro()
        {
        }

        public int IdRegistro { get => idRegistro; set => idRegistro = value; }
        public string Estado { get => estado; set => estado = value; }
        public string Fecha { get => fecha; set => fecha = value; }
        public string Horas { get => horas; set => horas = value; }
        public Actividad Actividad { get => actividad; set => actividad = value; }
        public EmpleadoTI EmpleadoTI { get => empleadoTI; set => empleadoTI = value; }
        public Empleado Empleado { get => empleado; set => empleado = value; }
        public string Observaciones { get => observaciones; set => observaciones = value; }
    }
}
