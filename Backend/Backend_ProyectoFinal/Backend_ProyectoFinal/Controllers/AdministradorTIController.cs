using Backend_ProyectoFinal.Data;
using Backend_ProyectoFinal.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Backend_ProyectoFinal.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AdministradorTIController : ControllerBase
    {
        [HttpGet]
        public IEnumerable<AdministradorTI> ObtenerAdministradoresTI()
        {
            return AdministradorTICAD.ObtenerEmpleadosTI();
        }

        [HttpGet("{user}")]
        public AdministradorTI ObtenerAdministradorTI(string user)
        {
            return AdministradorTICAD.ObtenerEmpleadoTI(user);
        }

        [HttpPost]
        public bool Post([FromBody] AdministradorTI a)
        {
            return AdministradorTICAD.InsertarAdministradorTI(a);
        }

        [HttpPut("{user}")]
        public bool Put(string user, [FromBody] AdministradorTI a)
        {
            return AdministradorTICAD.ModificarContraseniaAdministradorTI(user, a);
        }

        [HttpDelete("{user}")]
        public bool Delete(string user)
        {
            return AdministradorTICAD.EliminarAdministradorTI(user);
        }
    }
}
