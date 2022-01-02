using Backend_ProyectoFinal.Models;

namespace Backend_ProyectoFinal.Data
{
    public class DepartamentoCAD
    {
        public List<Departamento> ObtenerDepartamentos()
        {
            List<Departamento> departamentos = new List<Departamento>();
            return departamentos;
        }

        public Departamento ObtenerDepartamento(int idDepartamento)
        {
            Departamento d = new Departamento();
            return d;
        }

        public bool InsertarDepartamento(Departamento d)
        {
            return false;
        }

        public bool ModificarDepartamento(int idDepartamento)
        {
            return true;
        }

        public bool EliminarDepartamento(int idDepartamento)
        {
            return true;
        }
    }
}
