﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using RazorPagesIgnis.Models;

namespace RazorPagesIgnis.Migrations
{
    [DbContext(typeof(RazorPagesIgnisContext))]
    [Migration("20190606191446_Administrador")]
    partial class Administrador
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.4-servicing-10062");

            modelBuilder.Entity("RazorPagesIgnis.Administrador", b =>
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

            modelBuilder.Entity("RazorPagesIgnis.Cliente", b =>
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

            modelBuilder.Entity("RazorPagesIgnis.Proyecto", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Descripcion");

                    b.Property<string>("Nombre");

                    b.Property<bool>("Status");

                    b.HasKey("ID");

                    b.ToTable("Proyecto");
                });

            modelBuilder.Entity("RazorPagesIgnis.Rol", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Descripcion");

                    b.Property<string>("Nombre");

                    b.HasKey("ID");

                    b.ToTable("Rol");
                });

            modelBuilder.Entity("RazorPagesIgnis.Solicitud", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("HorasRealizadas");

                    b.Property<string>("NivelExperiencia");

                    b.Property<string>("Observaciones");

                    b.Property<int?>("ProyectoID");

                    b.Property<string>("RolRequerido");

                    b.Property<int?>("TecnicoAsignadoID");

                    b.HasKey("ID");

                    b.HasIndex("ProyectoID");

                    b.HasIndex("TecnicoAsignadoID");

                    b.ToTable("Solicitud");
                });

            modelBuilder.Entity("RazorPagesIgnis.Tecnico", b =>
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

            modelBuilder.Entity("RazorPagesIgnis.Solicitud", b =>
                {
                    b.HasOne("RazorPagesIgnis.Proyecto")
                        .WithMany("ListaDeSolicitudes")
                        .HasForeignKey("ProyectoID");

                    b.HasOne("RazorPagesIgnis.Tecnico", "TecnicoAsignado")
                        .WithMany()
                        .HasForeignKey("TecnicoAsignadoID");
                });
#pragma warning restore 612, 618
        }
    }
}
