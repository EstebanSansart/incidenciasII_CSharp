using Dominio;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistencia.Data.Configuration
{
    public class PersonaConfiguration : IEntityTypeConfiguration<Persona>
    {
        public void Configure(EntityTypeBuilder<Persona> builder)
        {
            builder.ToTable("persona");

            builder.HasKey(e => e.IdPersona);
            builder.Property(e => e.IdPersona)
            .HasMaxLengh(3);

            builder.Property(p => p.NombrePersona)
            .IsRequired();
            .HasMaxLengh(50);

            builder.HasOne(p => p.Genero)
            .WithMany(p => personas)
            .HasForeignKey(p => p.IdGeneroFk);

            builder.HasOne(p => p.Ciudad)
            .WithMany(p => p.Personas)
            .HasForeignKey(p => p.IdCiudadFk);

            builder.HasOne(p => p.TipoPersona)
            .WithMany(p => p.Personas)
            .HasForeignKey(p => p.IdTipoPerFk);
        }
    }
}