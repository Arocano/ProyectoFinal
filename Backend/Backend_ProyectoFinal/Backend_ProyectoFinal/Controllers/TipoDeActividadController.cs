using Backend_ProyectoFinal.Data;
using Backend_ProyectoFinal.Models;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Backend_ProyectoFinal.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TipoDeActividadController : ControllerBase
    {
        // GET: api/<TipoDeActividadController>
        [HttpGet]
        public IEnumerable<TipoDeActividad> Get()
        {
            return TipoDeActividadCAD.ObtenerTiposDeActividad();
        }

        // GET api/<TipoDeActividadController>/5
        [HttpGet("{id}")]
        public TipoDeActividad Get(int id)
        {
            return TipoDeActividadCAD.ObtenerTipoDeActividad(id);
        }

        // POST api/<TipoDeActividadController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<TipoDeActividadController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<TipoDeActividadController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
