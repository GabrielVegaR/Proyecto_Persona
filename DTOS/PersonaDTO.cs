namespace Proyecto_Persona.DTOS
{
    public class PersonaDTO
    {
        public int Id { get; set; }
        public string NombreCompleto { get; set; } = null!;
        public string Email { get; set; } = null!;
        public string TipoDocumento { get; set; } = null!;
        public string NumDocumento { get; set; } = null!;
        public string Telefono { get; set; }
        public string Direccion { get; set; } = null!;
        public int Edad { get; set; }
        public DateTime FechaCreacion { get; set; }

    }
}
