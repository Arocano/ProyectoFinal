namespace BackendPostgres.Models
{
    public class Usuario
    {
        private string user;
        private string contrasenia;
        private string nombre;
        private string apellido;
        private string correo;
        private string tipoUsuario;

        public Usuario(string user, string contra, string nombre, string apellido, string correo)
        {
            this.user = user;
            this.contrasenia = contra;
            this.nombre = nombre;
            this.apellido = apellido;
            this.correo = correo;
        }

        public Usuario()
        {
        }

        public Usuario(string user, string contrasenia, string nombre, string apellido, string correo, string tipoUsuario)
        {
            this.user = user;
            this.contrasenia = contrasenia;
            this.nombre = nombre;
            this.apellido = apellido;
            this.correo = correo;
            this.tipoUsuario = tipoUsuario;
        }

        public string User { get => user; set => user = value; }
        public string Contrasenia { get => contrasenia; set => contrasenia = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Apellido { get => apellido; set => apellido = value; }
        public string TipoUsuario { get => tipoUsuario; set => tipoUsuario = value; }
        public string Correo { get => correo; set => correo = value; }
    }
}
