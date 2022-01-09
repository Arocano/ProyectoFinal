using Backend_ProyectoFinal.Data;
using Backend_ProyectoFinal.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Backend_ProyectoFinal.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AutenticacionController : ControllerBase
    {
        public object UsuarioCAD { get; private set; }

        [HttpGet("{user}/{contra}")]
        public Usuario Login(string user, string contra)
        {
            return AutenticacionCAD.Login(user, contra);    
        }
    }
}
