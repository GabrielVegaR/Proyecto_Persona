namespace Proyecto_Persona.DTOS
{
    public class ActualizarPersonasDTO
    {
        public string? PrimerNombre { get; set; }
        public string? SegundoNombre { get; set; }
        public string? PrimerApellido { get; set; } 
        public string? SegundoApellido { get; set; }
        public string? Email { get; set; }
        public string? TipoDocumento { get; set; }
        public string? NumDocumento { get; set; }
        public string? CodigoArea { get; set; }
        public string? CodigoPais { get; set; }
        public string? Telefono { get; set; }
        public string? NumCasa { get; set; }
        public string? NombreCalle { get; set; }
        public string? NombreCiudad { get; set; }
        public string? NombrePais { get; set; }
        public int? DiaNacimiento { get; set; }
        public int? MesNacimiento { get; set; }
        public int? AñoNacimiento { get; set; }
    }
}
