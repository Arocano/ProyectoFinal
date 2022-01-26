namespace BackendPostgres.Models
{
    public class RegistroV2
    {
        public RegistroV2(int id, string estado, string fecha, string actividad, string horas, string usuario, string empleado, string observaciones)
        {
            Id = id;
            Estado = estado;
            Fecha = fecha;
            Actividad = actividad;
            Horas = horas;
            Usuario = usuario;
            Empleado = empleado;
            Observaciones = observaciones;
        }

        public int Id { get; set; }
        public string Estado { get; set; }
        public string Fecha { get; set; }
        public string Actividad { get; set; }
        public string Horas { get; set; }
        public string Usuario { get; set; }
        public string Empleado { get; set; }
        public string Observaciones { get; set; }


    }
}
