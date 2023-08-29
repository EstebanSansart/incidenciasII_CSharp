using Dominio.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistencia.Data.Configurations;
public class UsuarioConfiguration : IEntityTypeConfiguration<Usuario>
{
    public void Configure(EntityTypeBuilder<Usuario> builder)
    {
        builder.ToTable("usuario");

        builder.Property(p => p.Id)
        .IsRequired();

        builder.Property(p => p.Username)
        .IsRequired()
        .HasMaxLength(200);

        builder.HasIndex(p => new {
            p.Username,
            p.Email
        }).HasDatabaseName("IX_MiIndice")
        .IsUnique();

        builder.Property(p => p.Email)
        .IsRequired()
        .HasMaxLength(200);

        builder
        .HasMany(p => p.Roles)
        .WithMany(p => p.Usuarios)
        .UsingEntity<UsuariosRoles>(
            j => j
            .HasOne(pt => pt.Rol)
            .WithMany(t => t.UsuariosRoles)
            .HasForeignKey(pt => pt.RolId),
            j => j
            .HasOne(pt => pt.Usuario)
            .WithMany(t => t.UsuariosRoles)
            .HasForeignKey(pt => pt.UsuarioId),
            j =>
            {
                j.HasKey(t => new {t.UsuarioId, t.RolId});
            }
        );
    }
}