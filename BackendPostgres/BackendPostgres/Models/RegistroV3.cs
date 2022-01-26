namespace BackendPostgres.Models
{
    public class RegistroV3
    {
        public RegistroV3(string estado, string fecha, string horas, int actividad, string usuario, int empleado, string observaciones)
        {
            Estado = estado;
            Fecha = fecha;
            Horas = horas;
            Actividad = actividad;
            Usuario = usuario;
            Empleado = empleado;
            Observaciones = observaciones;
        }

        public RegistroV3()
        {
        }

        public string Estado { get; set; }
        public string Fecha { get; set; }
        public string Horas { get; set; }
        public int Actividad { get; set; }
        public string Usuario { get; set; }
        public int Empleado { get; set; } 
        public string Observaciones { get; set; }


    }
}
