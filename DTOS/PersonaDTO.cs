namespace Proyecto_Persona.DTOS
{
    public class PersonaDTO
    {
        public int Id { get; set; }
        public string PrimerNombre { get; set; } = null!;
        public string? SegundoNombre { get; set; }
        public string PrimerApellido { get; set; } = null!;
        public string SegundoApellido { get; set; } = null!;
        public string Email { get; set; } = null!;
        public string TipoDocumento { get; set; } = null!;
        public string NumDocumento { get; set; } = null!;
        public int CodigoArea { get; set; }
        public int CodigoPais { get; set; }
        public int Telefono { get; set; }
        public string NumCasa { get; set; } = null!;
        public string NombreCalle { get; set; } = null!;
        public string NombreCiudad { get; set; } = null!;
        public string NombrePais { get; set; } = null!;
        public int DiaNacimiento { get; set; }
        public int MesNacimiento { get; set; }
        public int AñoNacimiento { get; set; }
        public DateTime FechaCreacion { get; set; }

    }
}
