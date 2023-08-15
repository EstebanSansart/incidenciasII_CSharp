using Dominio;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistencia.Data.Configuration
{
    public class TipoPersonaConfiguration : IEntityTypeConfiguration<TipoPersona>
    {
        public void Configure(EntityTypeBuilder<TipoPersona> builder)
        {
            builder.ToTable("tipo_persona");

            builder.HasKey(e => e.IdTipoPersona);
            builder.Property(e => e.IdTipoPersona);

            builder.Property(p => p.NombreTipoPersona)
            .IsRequired();
            .HasMaxLengh(50);
        }
    }
}