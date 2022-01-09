﻿using Backend_ProyectoFinal.Data;
using Backend_ProyectoFinal.Models;
using Microsoft.AspNetCore.Mvc;


namespace Backend_ProyectoFinal.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ActividadController : ControllerBase
    {
        [HttpGet]
        public IEnumerable<Actividad> Get()
        {
            return ActividadCAD.ObtenerActividades();
        }

        [HttpGet("{tipo}")]
        public IEnumerable<Actividad> Get(string tipo)
        {
            return ActividadCAD.ObtenerActividades(tipo);
        }

        [HttpPost]
        public bool Post([FromBody] Actividad a)
        {
            return ActividadCAD.InsertarActividad(a);
        }

        [HttpPut ("{idActividad}")]
        public bool Put(int idActividad, [FromBody] Actividad a)
        {
            return ActividadCAD.ModificarActividad (idActividad, a);
        }

        [HttpDelete("{idActividad}")]
        public bool Delete(int idActividad)
        {
            return ActividadCAD.EliminarActividad(idActividad);
        }
    }
}
