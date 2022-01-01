namespace Backend_ProyectoFinal.Models
{
    public class EmpleadoTI : Usuario
    {
        public EmpleadoTI(int id, string user, string contra, string nombre, string apellido, string tipoUsuario) 
            : base(id, user, contra, nombre, apellido, tipoUsuario)
        {
        }

        public bool RegistrarActividad(Actividad a)
        {
            return false;
        }
    }
}
