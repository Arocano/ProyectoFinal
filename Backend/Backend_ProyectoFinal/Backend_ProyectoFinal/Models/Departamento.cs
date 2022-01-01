namespace Backend_ProyectoFinal.Models
{
    public class Departamento
    {
        private int idDepartamento;
        private string nombre;
        private string descripcion;

        public Departamento(int id, string nombre, string descripcion)
        {
            this.idDepartamento = id;
            this.nombre = nombre;
            this.descripcion = descripcion;
        }

        public Departamento()
        {
            this.idDepartamento= 0;
            this.nombre = "";
            this.descripcion = "";
        }

        public int IdDepartamento { get => idDepartamento; set => idDepartamento = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Descripcion { get => descripcion; set => descripcion = value; }
    }
}
