using BackendPostgres.Data;
using BackendPostgres.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BackendPostgres.Controllers
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
    }
}
