using Dominio;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistencia.Data.Configuration
{
    public class GeneroConfiguration : IEntityTypeConfiguration<Genero>
    {
        public void Configure(EntityTypeBuilder<Genero> builder)
        {
            builder.ToTable("genero");

            builder.HasKey(e => e.IdGenero);
            builder.Property(e => e.IdGenero)
            .HasMaxLengh(3);

            builder.Property(p => p.NombreGenero)
            .IsRequired();
            .HasMaxLengh(50);
        }
    }
}