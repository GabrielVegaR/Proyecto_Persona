using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Proyecto_Persona.Abstraciones.Servicios;
using Proyecto_Persona.DTOS;
using Proyecto_Persona.Implementaciones.Servicios;

namespace Proyecto_Persona.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PersonaController : ControllerBase
    {
        private readonly IServicioPersona servicioPersona;

        public PersonaController(IServicioPersona servicioPersona)
        {
            this.servicioPersona = servicioPersona;
        }

        [HttpGet]
        public IActionResult Index()
        {
            var listaPersona = servicioPersona.Get();

            return Ok(listaPersona);
        }

        [HttpPost]
        public IActionResult Crear(CrearPersonasDTO persona)
        {
            var create = servicioPersona.Crear(persona);

            return Ok(create);
        }

        [HttpPatch]
        public IActionResult Actualizar(int id, ActualizarPersonasDTO actualizarPersonas)
        {
            
            var update = servicioPersona.Actualizar(id, actualizarPersonas);
            return Ok(update);
        }

        [HttpDelete]
        public IActionResult Borrar(int id)
        {
            servicioPersona.Borrar(id);
            return Ok();
        }

        [HttpGet("id")]
        public IActionResult GetById(int id)
        {
            var persona = servicioPersona.GetById(id);

            return Ok(persona);
        }

    }

}
