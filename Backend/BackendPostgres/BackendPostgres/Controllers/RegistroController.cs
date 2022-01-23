using BackendPostgres.Data;
using BackendPostgres.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BackendPostgres.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RegistroController : ControllerBase
    {
        [HttpGet]
        public List<RegistroV2> Get()
        {
            return RegistroCAD.ObtenerRegistros();
        }

        [HttpPost]
        public bool Post([FromBody] RegistroV3 r)
        {
            return RegistroCAD.InsertarRegistro(r);
        }
    }
}
