namespace Backend_ProyectoFinal.Models
{
    public class EmpleadoTI : Usuario
    {
        public EmpleadoTI(string user, string contra, string nombre, string apellido, string correo) 
            : base(user, contra, nombre, apellido, correo)
        {
            this.TipoUsuario = "EmpleadoTI";
        }

        public EmpleadoTI()
        {

        }

        public bool RegistrarActividad(Actividad a)
        {
            return false;
        }
    }
}
