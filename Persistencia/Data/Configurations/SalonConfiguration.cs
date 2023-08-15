using Dominio;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistencia.Data.Configuration
{
    public class SalonConfiguration : IEntityTypeConfiguration<Salon>
    {
        public void Configure(EntityTypeBuilder<Salon> builder)
        {
            builder.ToTable("salon");

            builder.HasKey(e => e.IdSalon);
            builder.Property(e => e.IdSalon);

            builder.Property(p => p.NombreSalon)
            .IsRequired();
            .HasMaxLengh(50);

            builder.Property(p => p.Capacidad)
           .HasColumnType("int");
        }
    }
}