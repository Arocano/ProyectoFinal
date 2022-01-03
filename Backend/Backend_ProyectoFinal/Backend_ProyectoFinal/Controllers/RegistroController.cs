using Backend_ProyectoFinal.Data;
using Backend_ProyectoFinal.Models;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Backend_ProyectoFinal.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RegistroController : ControllerBase
    {
        // GET: api/<RegistroController>
        [HttpGet]
        public IEnumerable<Registro> Get()
        {
            return RegistroCAD.ObtenerRegistros();
        }
    }
}
