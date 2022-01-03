using Backend_ProyectoFinal.Data;
using Backend_ProyectoFinal.Models;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Backend_ProyectoFinal.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmpleadosController : ControllerBase
    {
        // GET: api/<EmpleadosController>
        [HttpGet]
        public IEnumerable<Empleado> Get()
        {
            return EmpleadoCAD.ObtenerEmpleados();
        }

        // GET api/<EmpleadosController>/5
        [HttpGet("{id}")]
        public Empleado Get(int id)
        {
            return EmpleadoCAD.ObtenerEmpleado(id);
        }

        // POST api/<EmpleadosController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<EmpleadosController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<EmpleadosController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
