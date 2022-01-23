using BackendPostgres.Data;
using BackendPostgres.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BackendPostgres.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ActividadController : ControllerBase
    {
        [HttpGet]
        public List<Actividad> Get()
        {
            return ActividadCAD.ObtenerActividades();
        }
    }
}
