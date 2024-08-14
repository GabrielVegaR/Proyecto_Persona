using Proyecto_Persona.DTOS;
using Proyecto_Persona.Models;

namespace Proyecto_Persona.Abstraciones.Repositorios
{
    public interface IRepositorioPersona
    {
        List<Persona> Get();

        Persona GetById(int id);

        Persona Crear(CrearPersonasDTO crearPersonasDTO);

        Persona Actualizar(int id, ActualizarPersonasDTO actualizarPersonasDTO);

        void Borrar(int id);

    }
}
