namespace Backend_ProyectoFinal.Models
{
    public class AdministradorTI : Usuario
    {
        public AdministradorTI(int id, string user, string contra, string nombre, string apellido, string tipoUsuario)
            : base(id, user, contra, nombre, apellido, tipoUsuario)
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
