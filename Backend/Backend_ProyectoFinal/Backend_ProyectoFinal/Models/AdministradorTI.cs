namespace Backend_ProyectoFinal.Models
{
    public class AdministradorTI : Usuario
    {
        public AdministradorTI(string user, string contra, string nombre, string apellido, string correo)
            : base(user, contra, nombre, apellido, correo)
        {
            this.TipoUsuario = "AdministradorTI";
        }

        public AdministradorTI()
        {

        }

        public List<Registro> ReporteTipoActividad()
        {
            List<Registro> reporte = new List<Registro>();
            return reporte;
        }

        public List<Registro> ReporteEmpleados()
        {
            List<Registro> reporte = new List<Registro>();
            return reporte;
        }

        public List<Registro> ReporteEstado()
        {
            List<Registro> reporte = new List<Registro>();
            return reporte;
        }
    }
}
