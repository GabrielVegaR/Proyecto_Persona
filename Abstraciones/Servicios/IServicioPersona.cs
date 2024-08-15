using Proyecto_Persona.DTOS;
using Proyecto_Persona.Models;

namespace Proyecto_Persona.Abstraciones.Servicios
{
    public interface IServicioPersona
    {
        List<PersonaDTO> Get();

        PersonaDTO? GetById(int id);

        PersonaDTO? Crear(CrearPersonasDTO crearPersonasDTO);

        PersonaDTO Actualizar(int id, ActualizarPersonasDTO actualizarPersonasDTO);

        void Borrar(int id);
    }
}
