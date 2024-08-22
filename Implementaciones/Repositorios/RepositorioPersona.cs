using Proyecto_Persona.Abstraciones.Repositorios;
using Proyecto_Persona.DTOS;
using Proyecto_Persona.Models;

namespace Proyecto_Persona.Implementaciones.Repositorios
{
    public class RepositorioPersona : IRepositorioPersona
    {
        private readonly PersonasContext _context;
        public RepositorioPersona(PersonasContext context)
        {
            _context = context;
        }

        public Persona Actualizar(int id, ActualizarPersonasDTO actualizarPersonasDTO)
        {
            var personaActual = GetById(id);
            if (personaActual == null)
            {
                throw new Exception();
            }

            personaActual.PrimerNombre = actualizarPersonasDTO.PrimerNombre ?? personaActual.PrimerNombre;
            personaActual.SegundoNombre = actualizarPersonasDTO.SegundoNombre ?? personaActual.SegundoNombre;
            personaActual.PrimerApellido = actualizarPersonasDTO.PrimerApellido ?? personaActual.PrimerApellido;
            personaActual.SegundoApellido = actualizarPersonasDTO.SegundoApellido ?? personaActual.SegundoApellido;
            personaActual.Email = actualizarPersonasDTO.Email ?? personaActual.Email;
            personaActual.TipoDocumento = actualizarPersonasDTO.TipoDocumento ?? personaActual.TipoDocumento;
            personaActual.NombreCalle = actualizarPersonasDTO.NumDocumento ?? personaActual.NombreCalle;
            personaActual.CodigoArea = actualizarPersonasDTO.CodigoArea ?? personaActual.CodigoArea;
            personaActual.CodigoPais = actualizarPersonasDTO.CodigoPais ?? personaActual.CodigoPais;
            personaActual.Telefono = actualizarPersonasDTO.Telefono ?? personaActual.Telefono;
            personaActual.NumCasa = actualizarPersonasDTO.NumCasa ?? personaActual.NumCasa;
            personaActual.NombreCalle = actualizarPersonasDTO.NombreCalle ?? personaActual.NombreCalle;
            personaActual.NombreCiudad = actualizarPersonasDTO.NombreCiudad ?? personaActual.NombreCiudad;
            personaActual.NombrePais = actualizarPersonasDTO.NombrePais ?? personaActual.NombrePais;
            personaActual.DiaNacimiento = actualizarPersonasDTO.DiaNacimiento ?? personaActual.DiaNacimiento;
            personaActual.MesNacimiento = actualizarPersonasDTO.MesNacimiento ?? personaActual.MesNacimiento;
            personaActual.AñoNacimiento = actualizarPersonasDTO.AñoNacimiento ?? personaActual.AñoNacimiento;


            var result = _context.Update(personaActual);
            _context.SaveChanges();
            return result.Entity;

        }

        public void Borrar(int id)
        {
            var borrar = GetById(id);
            if (borrar == null)
            {
                throw new Exception("El usuario especificado no ha sido encontrado");
            }
            _context.Personas.Remove(borrar);
            _context.SaveChanges();
        }

        public Persona? Crear(CrearPersonasDTO crearPersonasDTO)
        {
            var persona = new Persona {
                PrimerNombre = crearPersonasDTO.PrimerNombre,
                SegundoNombre = crearPersonasDTO.SegundoNombre?.ToString() ?? "",
                PrimerApellido = crearPersonasDTO.PrimerApellido.ToString(),
                SegundoApellido = crearPersonasDTO.SegundoApellido.ToString(),
                Email = crearPersonasDTO.Email,
                TipoDocumento = crearPersonasDTO.TipoDocumento,
                NumDocumento = crearPersonasDTO.NumDocumento,
                CodigoArea = crearPersonasDTO.CodigoArea,
                CodigoPais = crearPersonasDTO.CodigoPais,
                Telefono = crearPersonasDTO.Telefono,
                NumCasa = crearPersonasDTO.NumCasa,
                NombreCalle = crearPersonasDTO.NombreCalle,
                NombreCiudad = crearPersonasDTO.NombreCiudad,
                NombrePais = crearPersonasDTO.NombrePais,
                DiaNacimiento = crearPersonasDTO.DiaNacimiento,
                MesNacimiento = crearPersonasDTO.MesNacimiento,
                AñoNacimiento = crearPersonasDTO.AñoNacimiento,
                FechaCreacion = DateTime.Now
            };

            var result = _context.Add(persona);
            _context.SaveChanges();
            
            return GetById(result.Entity.Id);
        }

        public List<Persona> Get()
        {
            return [.. _context.Personas];
        }

        public Persona? GetById(int id)
        {
            return _context.Personas.Where(p => p.Id == id).FirstOrDefault();
        }
    }
}
