namespace Backend_ProyectoFinal.Models
{
    public class Usuario
    {
        private int idUsuario;
        private string user;
        private string contrasenia;
        private string nombre;
        private string apellido;
        private string tipoUsuario;

        public Usuario(int id, string user, string contra, string nombre, string apellido, string tipoUsuario)
        {
            this.idUsuario = id;
            this.user = user;
            this.contrasenia = contra;
            this.nombre = nombre;
            this.apellido = apellido;
            this.tipoUsuario = tipoUsuario;
        }

        public Usuario()
        {
        }

        public int IdUsuario { get => idUsuario; set => idUsuario = value; }
        public string User { get => user; set => user = value; }
        public string Contrasenia { get => contrasenia; set => contrasenia = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Apellido { get => apellido; set => apellido = value; }
        public string TipoUsuario { get => tipoUsuario; set => tipoUsuario = value; }
    }
}
