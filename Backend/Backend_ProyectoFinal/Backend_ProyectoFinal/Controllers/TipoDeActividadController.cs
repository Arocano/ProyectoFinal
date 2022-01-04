using Backend_ProyectoFinal.Data;
using Backend_ProyectoFinal.Models;
using Microsoft.AspNetCore.Mvc;


namespace Backend_ProyectoFinal.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TipoDeActividadController : ControllerBase
    {
        [HttpGet]
        public IEnumerable<TipoDeActividad> Get()
        {
            return TipoDeActividadCAD.ObtenerTiposDeActividad();
        }

        [HttpGet("{id}")]
        public TipoDeActividad Get(int id)
        {
            return TipoDeActividadCAD.ObtenerTipoDeActividad(id);
        }

        [HttpPost]
        public bool Post([FromBody] TipoDeActividad t)
        {
            return TipoDeActividadCAD.InsertarTipoDeActividad(t);
        }

        [HttpPut("{id}")]
        public bool Put(int id, [FromBody] TipoDeActividad t)
        {
            return TipoDeActividadCAD.ModificarTipoDeActividad(id, t);
        }

        [HttpDelete("{id}")]
        public bool Delete(int id)
        {
            return TipoDeActividadCAD.EliminarTipoDeActividad(id);
        }
    }
}
