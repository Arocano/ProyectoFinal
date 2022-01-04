using Backend_ProyectoFinal.Data;
using Backend_ProyectoFinal.Models;
using Microsoft.AspNetCore.Mvc;

namespace Backend_ProyectoFinal.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RegistroController : ControllerBase
    {
        [HttpGet]
        public IEnumerable<Registro> Get()
        {
            return RegistroCAD.ObtenerRegistros();
        }

        [HttpPost]
        public bool Post([FromBody] Registro r)
        {
            return RegistroCAD.InsertarRegistro(r);
        }

        [HttpPut("{id}")]
        public bool Put(int id, [FromBody] Registro r)
        {
            return RegistroCAD.ModificarRegistro(id, r);
        }

        [HttpDelete("{id}")]
        public bool Delete(int id)
        {
            return RegistroCAD.EliminarRegistro(id);
        }
    }
}
