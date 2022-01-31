namespace BackendPostgres.Models
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
    }
}
