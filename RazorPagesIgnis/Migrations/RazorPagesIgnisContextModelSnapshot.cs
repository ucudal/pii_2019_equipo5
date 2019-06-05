﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using RazorPagesIgnis.Models;

namespace RazorPagesIgnis.Migrations
{
    [DbContext(typeof(RazorPagesIgnisContext))]
    partial class RazorPagesIgnisContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.4-servicing-10062");

            modelBuilder.Entity("Ignis.Administrador", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Contrasena");

                    b.Property<string>("Correo");

                    b.Property<string>("Nombre");

                    b.Property<bool>("Status");

                    b.HasKey("ID");

                    b.ToTable("Administrador");
                });

            modelBuilder.Entity("Ignis.Cliente", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Contrasena");

                    b.Property<string>("Correo");

                    b.Property<string>("Nombre");

                    b.Property<bool>("Status");

                    b.HasKey("ID");

                    b.ToTable("Cliente");
                });

            modelBuilder.Entity("Ignis.Proyecto", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Descripcion");

                    b.Property<string>("Nombre");

                    b.Property<bool>("Status");

                    b.HasKey("ID");

                    b.ToTable("Proyecto");
                });

            modelBuilder.Entity("Ignis.Solicitud", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("HorasRealizadas");

                    b.Property<int?>("ProyectoID");

                    b.Property<string>("Solicitud_Experiencia");

                    b.Property<string>("Solicitud_Obs");

                    b.Property<string>("Solicitud_Rol");

                    b.Property<int?>("TecnicoAsignadoID");

                    b.HasKey("ID");

                    b.HasIndex("ProyectoID");

                    b.HasIndex("TecnicoAsignadoID");

                    b.ToTable("Solicitud");
                });

            modelBuilder.Entity("Ignis.Tecnico", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Contrasena");

                    b.Property<string>("Correo");

                    b.Property<int>("Edad");

                    b.Property<string>("Nivel_experiencia");

                    b.Property<string>("Nombre");

                    b.Property<string>("Presentacion");

                    b.Property<bool>("Status");

                    b.HasKey("ID");

                    b.ToTable("Tecnico");
                });

            modelBuilder.Entity("Ignis.Solicitud", b =>
                {
                    b.HasOne("Ignis.Proyecto")
                        .WithMany("ListaDeSolicitudes")
                        .HasForeignKey("ProyectoID");

                    b.HasOne("Ignis.Tecnico", "TecnicoAsignado")
                        .WithMany()
                        .HasForeignKey("TecnicoAsignadoID");
                });
#pragma warning restore 612, 618
        }
    }
}
