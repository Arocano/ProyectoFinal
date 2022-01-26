using BackendPostgres.Data;
using BackendPostgres.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BackendPostgres.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmpleadoTIController : ControllerBase
    {
        [HttpGet]
        public List<EmpleadoTI> Get()
        {
            return EmpleadoTICAD.ObtenerEmpleadosTI();
        }

        [HttpGet("{user}")]
        public EmpleadoTI Get(String user)
        {
            return EmpleadoTICAD.ObtenerEmpleadoTI(user);
        }

        [HttpPost]
        public bool Post([FromBody] EmpleadoTI e)
        {
            return EmpleadoTICAD.InsertarEmpleadoTI(e);
        }

        [HttpPut("{user}/{pass}")]
        public bool Put(string user, string pass)
        {
            return EmpleadoTICAD.ModificarContraseniaEmpleadoTI(user, pass);
        }
    }
}
