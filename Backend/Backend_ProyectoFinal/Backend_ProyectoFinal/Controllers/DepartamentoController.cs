using Backend_ProyectoFinal.Data;
using Backend_ProyectoFinal.Models;
using Microsoft.AspNetCore.Mvc;


namespace Backend_ProyectoFinal.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DepartamentoController : ControllerBase
    {
        [HttpGet]
        public IEnumerable<Departamento> Get()
        {
            return DepartamentoCAD.ObtenerDepartamentos();
        }

        [HttpGet("{id}")]
        public Departamento Get(int id)
        {
            return DepartamentoCAD.ObtenerDepartamento(id);
        }

        [HttpPost]
        public bool Post([FromBody] Departamento d)
        {
            return DepartamentoCAD.InsertarDepartamento(d);
        }

        [HttpPut("{id}")]
        public bool Put(int id, [FromBody] Departamento d)
        {
            return DepartamentoCAD.ModificarDepartamento(id, d);
        }

        [HttpDelete("{idDepartamento}")]
        public bool Delete(int idDepartamento)
        {
            return DepartamentoCAD.EliminarDepartamento(idDepartamento);
        }
    }
}
