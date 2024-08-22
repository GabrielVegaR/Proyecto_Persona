using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Proyecto_Persona.Models;

public partial class Persona
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int Id { get; set; }

    public string PrimerNombre { get; set; } = null!;

    public string? SegundoNombre { get; set; }

    public string PrimerApellido { get; set; } = null!;

    public string SegundoApellido { get; set; } = null!;

    public string Email { get; set; } = null!;

    public string TipoDocumento { get; set; } = null!;

    public string NumDocumento { get; set; } = null!;

    public string CodigoArea { get; set; } 

    public string CodigoPais { get; set; }

    public string Telefono { get; set; }

    public string NumCasa { get; set; } = null!;

    public string NombreCalle { get; set; } = null!;

    public string NombreCiudad { get; set; } = null!;

    public string NombrePais { get; set; } = null!;

    public int DiaNacimiento { get; set; }

    public int MesNacimiento { get; set; }

    public int AñoNacimiento { get; set; }

    public DateTime FechaCreacion { get; set; }
}
