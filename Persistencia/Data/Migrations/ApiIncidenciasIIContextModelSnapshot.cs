﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Persistencia;

#nullable disable

namespace Persistencia.Data.Migrations
{
    [DbContext(typeof(ApiIncidenciasIIContext))]
    partial class ApiIncidenciasIIContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("Dominio.Ciudad", b =>
                {
                    b.Property<string>("IdCiudad")
                        .HasMaxLength(3)
                        .HasColumnType("varchar(3)");

                    b.Property<string>("IdDepFk")
                        .HasColumnType("varchar(3)");

                    b.Property<string>("NombreCiudad")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)");

                    b.HasKey("IdCiudad");

                    b.HasIndex("IdDepFk");

                    b.ToTable("ciudad", (string)null);
                });

            modelBuilder.Entity("Dominio.Departamento", b =>
                {
                    b.Property<string>("IdDep")
                        .HasMaxLength(3)
                        .HasColumnType("varchar(3)");

                    b.Property<string>("IdPaisFk")
                        .HasColumnType("varchar(3)");

                    b.Property<string>("NombreDep")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)");

                    b.HasKey("IdDep");

                    b.HasIndex("IdPaisFk");

                    b.ToTable("departamento", (string)null);
                });

            modelBuilder.Entity("Dominio.Genero", b =>
                {
                    b.Property<int>("IdGenero")
                        .ValueGeneratedOnAdd()
                        .HasMaxLength(3)
                        .HasColumnType("int");

                    b.Property<string>("NombreGenero")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)");

                    b.HasKey("IdGenero");

                    b.ToTable("genero", (string)null);
                });

            modelBuilder.Entity("Dominio.Matricula", b =>
                {
                    b.Property<int>("IdMatricula")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("IdPersonaFk")
                        .HasColumnType("longtext");

                    b.Property<int>("IdSalonFk")
                        .HasColumnType("int");

                    b.Property<string>("PersonaIdPersona")
                        .HasColumnType("varchar(3)");

                    b.Property<int?>("SalonIdSalon")
                        .HasColumnType("int");

                    b.HasKey("IdMatricula");

                    b.HasIndex("PersonaIdPersona");

                    b.HasIndex("SalonIdSalon");

                    b.ToTable("matricula", (string)null);
                });

            modelBuilder.Entity("Dominio.Pais", b =>
                {
                    b.Property<string>("IdPais")
                        .HasMaxLength(3)
                        .HasColumnType("varchar(3)");

                    b.Property<string>("NombrePais")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)");

                    b.HasKey("IdPais");

                    b.ToTable("pais", (string)null);
                });

            modelBuilder.Entity("Dominio.Persona", b =>
                {
                    b.Property<string>("IdPersona")
                        .HasMaxLength(3)
                        .HasColumnType("varchar(3)");

                    b.Property<string>("IdCiudadFk")
                        .HasMaxLength(3)
                        .HasColumnType("varchar(3)");

                    b.Property<int>("IdGeneroFk")
                        .HasColumnType("int");

                    b.Property<int>("IdTipoPerFk")
                        .HasColumnType("int");

                    b.Property<string>("NombrePersona")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)");

                    b.HasKey("IdPersona");

                    b.HasIndex("IdCiudadFk");

                    b.HasIndex("IdGeneroFk");

                    b.HasIndex("IdTipoPerFk");

                    b.ToTable("persona", (string)null);
                });

            modelBuilder.Entity("Dominio.Salon", b =>
                {
                    b.Property<int>("IdSalon")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("Capacidad")
                        .HasColumnType("int");

                    b.Property<string>("NombreSalon")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)");

                    b.HasKey("IdSalon");

                    b.ToTable("salon", (string)null);
                });

            modelBuilder.Entity("Dominio.TipoPersona", b =>
                {
                    b.Property<int>("IdTipoPersona")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("DescripcionTipoPersona")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)");

                    b.HasKey("IdTipoPersona");

                    b.ToTable("tipo_persona", (string)null);
                });

            modelBuilder.Entity("Dominio.TrainerSalon", b =>
                {
                    b.Property<int>("IdSalonFk")
                        .HasColumnType("int");

                    b.Property<string>("IdPerTrainerFk")
                        .HasMaxLength(20)
                        .HasColumnType("varchar(20)");

                    b.HasKey("IdSalonFk", "IdPerTrainerFk");

                    b.HasIndex("IdPerTrainerFk");

                    b.ToTable("trainer_salon", (string)null);
                });

            modelBuilder.Entity("Dominio.Ciudad", b =>
                {
                    b.HasOne("Dominio.Departamento", "Departamento")
                        .WithMany("Ciudades")
                        .HasForeignKey("IdDepFk");

                    b.Navigation("Departamento");
                });

            modelBuilder.Entity("Dominio.Departamento", b =>
                {
                    b.HasOne("Dominio.Pais", "Pais")
                        .WithMany("Departamentos")
                        .HasForeignKey("IdPaisFk");

                    b.Navigation("Pais");
                });

            modelBuilder.Entity("Dominio.Matricula", b =>
                {
                    b.HasOne("Dominio.Persona", "Persona")
                        .WithMany("Matriculas")
                        .HasForeignKey("PersonaIdPersona");

                    b.HasOne("Dominio.Salon", "Salon")
                        .WithMany("Matriculas")
                        .HasForeignKey("SalonIdSalon");

                    b.Navigation("Persona");

                    b.Navigation("Salon");
                });

            modelBuilder.Entity("Dominio.Persona", b =>
                {
                    b.HasOne("Dominio.Ciudad", "Ciudad")
                        .WithMany("Personas")
                        .HasForeignKey("IdCiudadFk");

                    b.HasOne("Dominio.Genero", "Genero")
                        .WithMany("Personas")
                        .HasForeignKey("IdGeneroFk")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Dominio.TipoPersona", "TipoPersona")
                        .WithMany("Personas")
                        .HasForeignKey("IdTipoPerFk")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Ciudad");

                    b.Navigation("Genero");

                    b.Navigation("TipoPersona");
                });

            modelBuilder.Entity("Dominio.TrainerSalon", b =>
                {
                    b.HasOne("Dominio.Persona", "Persona")
                        .WithMany("TrainerSalones")
                        .HasForeignKey("IdPerTrainerFk")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Dominio.Salon", "Salon")
                        .WithMany("TrainerSalones")
                        .HasForeignKey("IdSalonFk")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Persona");

                    b.Navigation("Salon");
                });

            modelBuilder.Entity("Dominio.Ciudad", b =>
                {
                    b.Navigation("Personas");
                });

            modelBuilder.Entity("Dominio.Departamento", b =>
                {
                    b.Navigation("Ciudades");
                });

            modelBuilder.Entity("Dominio.Genero", b =>
                {
                    b.Navigation("Personas");
                });

            modelBuilder.Entity("Dominio.Pais", b =>
                {
                    b.Navigation("Departamentos");
                });

            modelBuilder.Entity("Dominio.Persona", b =>
                {
                    b.Navigation("Matriculas");

                    b.Navigation("TrainerSalones");
                });

            modelBuilder.Entity("Dominio.Salon", b =>
                {
                    b.Navigation("Matriculas");

                    b.Navigation("TrainerSalones");
                });

            modelBuilder.Entity("Dominio.TipoPersona", b =>
                {
                    b.Navigation("Personas");
                });
#pragma warning restore 612, 618
        }
    }
}
