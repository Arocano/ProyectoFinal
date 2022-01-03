using Backend_ProyectoFinal.Data;
using Backend_ProyectoFinal.Models;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Backend_ProyectoFinal.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ActividadController : ControllerBase
    {
        // GET: api/<ActividadController>
        [HttpGet]
        public IEnumerable<Actividad> Get()
        {
            return ActividadCAD.ObtenerActividades();
        }

        // GET api/<ActividadController>/5
        [HttpGet("{id}")]
        public Actividad Get(int id)
        {
            return ActividadCAD.ObtenerActividad(id);
        }

        // POST api/<ActividadController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<ActividadController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<ActividadController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
