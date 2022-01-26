using BackendPostgres.Data;
using BackendPostgres.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BackendPostgres.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TipoDeActividadController : ControllerBase
    {
        [HttpGet]
        public List<TipoDeActividad> Get()
        {
            return TipoDeActividadCAD.ObtenerTipos();
        }

        [HttpGet("{id}")]
        public TipoDeActividad Get(int id)
        {
            return TipoDeActividadCAD.ObtenerTipo(id);
        }
    }
}
