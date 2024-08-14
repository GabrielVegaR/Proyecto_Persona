using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;

namespace Proyecto_Persona.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PesonaController : ControllerBase
    {
        [HttpGet]
        public IActionResult Index()
        {
            var result = "Estas Retornando un Metodo GET";
            return Ok(result);
        }

        [HttpPost]
        public IActionResult Crear()
        {
            var result = "Estas Retornando un Metodo POST";
            return Ok(result);
        }

        [HttpPatch]
        public IActionResult Actualizar()
        {
            var result = "Estas Retornando un Metodo Patch";
            return Ok(result);
        }

        [HttpDelete]
        public IActionResult Borrar()
        {
            var result = "Estas Retornando un Metodo DELETE";
            return Ok(result);
        }

    }

}
