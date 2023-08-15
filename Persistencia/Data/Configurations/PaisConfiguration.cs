using Dominio;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistencia.Data.Configuration
{
    public class PaisConfiguration : IEntityTypeConfiguration<Pais>
    {
        public void Configure(EntityTypeBuilder<Pais> builder)
        {
            builder.ToTable("pais");

            builder.HasKey(e => e.IdPais);
            builder.Property(e => e.IdPais)
            .HasMaxLengh(3);

            builder.Property(p => p.NombrePais)
            .IsRequired();
            .HasMaxLengh(50);
        }
    }
}