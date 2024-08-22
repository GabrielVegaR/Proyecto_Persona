using Proyecto_Persona.Abstraciones.Repositorios;
using Proyecto_Persona.Abstraciones.Servicios;
using Proyecto_Persona.DTOS;
using Proyecto_Persona.Models;

namespace Proyecto_Persona.Implementaciones.Servicios
{
    public class ServicioPersona : IServicioPersona
    {
        private readonly IRepositorioPersona repositorioPersona;

        public ServicioPersona(IRepositorioPersona repositorioPersona)
        {
            this.repositorioPersona = repositorioPersona;
        }

        public PersonaDTO Actualizar(int id, ActualizarPersonasDTO actualizarPersonasDTO)
        {
            var persona = repositorioPersona.Actualizar(id, actualizarPersonasDTO);

            var personaDTO = ConvertirAPersonaDTO(persona);

            return personaDTO;
        }

        public void Borrar(int id)
        {
            repositorioPersona.Borrar(id);
        }

        public PersonaDTO? Crear(CrearPersonasDTO crearPersonasDTO)
        {
            var persona = repositorioPersona.Crear(crearPersonasDTO);
            if (persona == null)
            {
                return null;
            }
            var personaDTO = ConvertirAPersonaDTO(persona);

            return personaDTO;
        }

        public List<PersonaDTO> Get()
        {
            var listaPersona = repositorioPersona.Get();
            var personaDTO = new List<PersonaDTO>();

            foreach (Persona persona in listaPersona)
            {
                var result = ConvertirAPersonaDTO(persona);
                personaDTO.Add(result);
            };

            return personaDTO;
        }

        public PersonaDTO? GetById(int id)
        {
            var persona = repositorioPersona.GetById(id);

            var personaDTO = ConvertirAPersonaDTO(persona);

            return personaDTO;
        }

        //public Persona ConvertirAPersona(PersonaDTO personaDTO)
        //{
        //    var persona = new Persona
        //    {
        //        NombreCompleto = personaDTO.NombreCompleto,
        //        SegundoNombre = personaDTO.SegundoNombre,
        //        PrimerApellido = personaDTO.PrimerApellido,
        //        SegundoApellido = personaDTO.SegundoApellido,
        //        Email = personaDTO.Email,
        //        TipoDocumento = personaDTO.TipoDocumento,
        //        NumDocumento = personaDTO.NumDocumento,
        //        CodigoArea = personaDTO.CodigoArea,
        //        CodigoPais = personaDTO.CodigoPais,
        //        Telefono = personaDTO.Telefono,
        //        NumCasa = personaDTO.NumCasa,
        //        NombreCalle = personaDTO.NombreCalle,
        //        NombreCiudad = personaDTO.NombreCiudad,
        //        NombrePais = personaDTO.NombrePais,
        //        DiaNacimiento = personaDTO.DiaNacimiento,
        //        MesNacimiento = personaDTO.MesNacimiento,
        //        AñoNacimiento = personaDTO.AñoNacimiento
        //    };

        //    return persona;
        //}

        public PersonaDTO ConvertirAPersonaDTO(Persona persona)
        {
            var personaDTO = new PersonaDTO
            {
                Id = persona.Id,
                NombreCompleto = $"{persona.PrimerNombre} {persona.SegundoNombre?.Trim()} {persona.PrimerApellido} {persona.SegundoApellido}".Trim(),
                Email = persona.Email,
                TipoDocumento = persona.TipoDocumento,
                NumDocumento = persona.NumDocumento,
                Telefono = persona.CodigoArea + persona.CodigoPais + persona.Telefono,
                Direccion = persona.NumCasa + ", " + persona.NombreCalle + ", " + persona.NombreCiudad + ", " + persona.NombrePais,
                Edad = DateTime.Now.Year - persona.AñoNacimiento,                
                FechaCreacion = persona.FechaCreacion
            };

            return personaDTO;
        }
    }
}
