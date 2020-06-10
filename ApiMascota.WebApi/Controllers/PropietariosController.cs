using ApiMascota.WebApi.Data;
using ApiMascota.WebApi.Data.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiMascota.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PropietariosController : ControllerBase
    {
        private readonly ApiMascotasContext context;

        public PropietariosController(ApiMascotasContext context)
        {
            this.context = context;
           
        }

        [HttpGet]
        public ActionResult<IEnumerable<Propietario>> Get()
        {
            return context.Propietarios.ToList();

        }

        [HttpGet("{id}", Name = "ObtenerPropietarioPorId")]
        public ActionResult<Propietario> Get(int id)
        {
            var propietario = context.Propietarios.FirstOrDefault(p => p.Id == id);
            if (propietario == null)
            {
                return NotFound();
            }
            return propietario;
        }

        [HttpPost]
        public async Task<ActionResult<Propietario>> Post([FromBody] Propietario propietario)
        {


            await context.Propietarios.AddAsync(propietario);
            await context.SaveChangesAsync();

            //return propietario;
            return new CreatedAtRouteResult("ObtenerPropietarioPorId", new { id = propietario.Id }, propietario);
        }

        [HttpPut("{id}")]
        public ActionResult<Propietario> Put(int id, [FromBody] Propietario propietario)
        {
            if (id != propietario.Id)
            {
                return BadRequest();
            }

            context.Entry(propietario).State = EntityState.Modified;
            context.SaveChanges();
            return Ok();
        }

                [HttpDelete("{id}")]
        public ActionResult<Propietario> Delete(int id)
        {

                var propietario = context.Propietarios.FirstOrDefault(p => p.Id == id);
                if (propietario == null)
                {
                    return NotFound();
                }
                context.Propietarios.Remove(propietario);
                context.SaveChanges();
                return Ok();

        }
    }
}
