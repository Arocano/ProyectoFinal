using BackendPostgres.Data;
using BackendPostgres.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BackendPostgres.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AutenticacionController : ControllerBase
    {
        [HttpGet("{user}/{contra}")]
        public Usuario Login(string user, string contra)
        {
            return AutenticacionCAD.ObtenerUsuario(user, contra);
        }

        [HttpGet]
        public List<Usuario> Get()
        {
            return AutenticacionCAD.ObtenerUsuarios();
        }

        [HttpGet("user/{user}")]
        public Usuario Get(string user)
        {
            return AutenticacionCAD.ObtenerUsuario(user);
        }
    }
}
