using Dominio;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistencia.Data.Configuration
{
    public class CiudadConfiguration : IEntityTypeConfiguration<Ciudad>
    {
        public void Configure(EntityTypeBuilder<Ciudad> builder)
        {
            builder.ToTable("ciudad");

            builder.HasKey(e => e.IdCiudad);
            builder.Property(e => e.IdCiudad)
            .HasMaxLenght(3);

            builder.Property(p => p.NombreCiudad)
           .IsRequired()
           .HasMaxLengh(50);

           builder.HasOne(p => p.Departamento)
           .WithMany(p => p.Ciudades)
           .HasForeignKey(p = p.IdDepFk);
        }
    }
}