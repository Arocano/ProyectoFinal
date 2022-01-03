using Backend_ProyectoFinal.Data;
using Backend_ProyectoFinal.Models;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Backend_ProyectoFinal.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DepartamentoController : ControllerBase
    {
        // GET: api/<DepartamentoController>
        [HttpGet]
        public IEnumerable<Departamento> Get()
        {
            return DepartamentoCAD.ObtenerDepartamentos();
        }

        // GET api/<DepartamentoController>/5
        [HttpGet("{id}")]
        public Departamento Get(int id)
        {
            return DepartamentoCAD.ObtenerDepartamento(id);
        }

        // POST api/<DepartamentoController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<DepartamentoController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<DepartamentoController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
