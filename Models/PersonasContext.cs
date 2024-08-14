using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace Proyecto_Persona.Models;

public partial class PersonasContext : DbContext
{
    public PersonasContext()
    {
    }

    public PersonasContext(DbContextOptions<PersonasContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Persona> Personas { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Server=DESKTOP-GC6BP3L;Database=personas;User Id=sa;Password=alturo123;Encrypt=True;TrustServerCertificate=True;");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Persona>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__persona__3213E83F66D78D6C");

            entity.ToTable("persona");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.AñoNacimiento).HasColumnName("añoNacimiento");
            entity.Property(e => e.CodigoArea).HasColumnName("codigoArea");
            entity.Property(e => e.CodigoPais).HasColumnName("codigoPais");
            entity.Property(e => e.DiaNacimiento).HasColumnName("diaNacimiento");
            entity.Property(e => e.Email)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("email");
            entity.Property(e => e.FechaCreacion)
                .HasColumnType("datetime")
                .HasColumnName("fechaCreacion");
            entity.Property(e => e.MesNacimiento).HasColumnName("mesNacimiento");
            entity.Property(e => e.NombreCalle)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("nombreCalle");
            entity.Property(e => e.NombreCiudad)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("nombreCiudad");
            entity.Property(e => e.NombrePais)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("nombrePais");
            entity.Property(e => e.NumCasa)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("numCasa");
            entity.Property(e => e.NumDocumento)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("numDocumento");
            entity.Property(e => e.PrimerApellido)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("primerApellido");
            entity.Property(e => e.PrimerNombre)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("primerNombre");
            entity.Property(e => e.SegundoApellido)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("segundoApellido");
            entity.Property(e => e.SegundoNombre)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("segundoNombre");
            entity.Property(e => e.Telefono).HasColumnName("telefono");
            entity.Property(e => e.TipoDocumento)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("tipoDocumento");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
