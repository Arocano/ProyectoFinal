using Backend_ProyectoFinal.Data;
using Backend_ProyectoFinal.Models;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Backend_ProyectoFinal.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmpleadoTIController : ControllerBase
    {
        // GET: api/<EmpleadoTIController>
        [HttpGet]
        public IEnumerable<EmpleadoTI> Get()
        {
            return EmpleadoTICAD.ObtenerEmpleadosTI();
        }

        // GET api/<EmpleadoTIController>/5
        [HttpGet("{user}")]
        public EmpleadoTI Get(String user)
        {
            return EmpleadoTICAD.ObtenerEmpleadoTI(user);
        }
    }
}
