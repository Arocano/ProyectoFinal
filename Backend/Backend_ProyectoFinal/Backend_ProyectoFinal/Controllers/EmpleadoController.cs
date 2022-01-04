using Backend_ProyectoFinal.Data;
using Backend_ProyectoFinal.Models;
using Microsoft.AspNetCore.Mvc;


namespace Backend_ProyectoFinal.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmpleadoController : ControllerBase
    {
        [HttpGet]
        public IEnumerable<Empleado> Get()
        {
            return EmpleadoCAD.ObtenerEmpleados();
        }

        [HttpGet("{id}")]
        public Empleado Get(int id)
        {
            return EmpleadoCAD.ObtenerEmpleado(id);
        }

        [HttpPost]
        public bool InsertarEmpleado([FromBody] Empleado e)
        {
            return EmpleadoCAD.InsertarEmpleado(e);
        }

        [HttpPut("{id}")]
        public bool Put(int id, [FromBody] Empleado e)
        {
            return EmpleadoCAD.ModificarEmpleado(id, e);
        }

        [HttpDelete("{id}")]
        public bool Delete(int id)
        {
            return EmpleadoCAD.EliminarEmpleado(id);
        }
    }
}
