﻿using Backend_ProyectoFinal.Data;
using Backend_ProyectoFinal.Models;
using Microsoft.AspNetCore.Mvc;


namespace Backend_ProyectoFinal.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmpleadoTIController : ControllerBase
    {
        [HttpGet]
        public IEnumerable<EmpleadoTI> Get()
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

        [HttpPut("{id}")]
        public bool Put(int id, [FromBody] EmpleadoTI e)
        {
            return EmpleadoTICAD.ModificarEmpleadoTI(id, e);    
        }

        [HttpDelete("{user}")]
        public bool Delete(string user)
        {
            return EmpleadoTICAD.EliminarEmpleadoTI(user);
        }
    }
}