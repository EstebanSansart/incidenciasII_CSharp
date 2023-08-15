using Dominio;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistencia.Data.Configuration
{
    public class DepartamentoConfiguration : IEntityTypeConfiguration<Departamento>
    {
        public void Configure(EntityTypeBuilder<Departamento> builder)
        {
            builder.ToTable("departamento");

            builder.HasKey(e => e.IdDep);
            builder.Property(e => e.IdDep)
            .HasMaxLengh(3);

            builder.Property(p => p.NombreDep)
            .IsRequired();
            .HasMaxLengh(50);

            builder.HasOne(p => p.Pais)
            .WithMany(p => p.Departamentos)
            .HasForeignKey(p => p.IdPaisFk);
        }
    }
}