﻿// <auto-generated />
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

            modelBuilder.Entity("RazorPagesIgnis.Models.Proyecto", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Descripcion");

                    b.Property<string>("Titulo");

                    b.HasKey("ID");

                    b.ToTable("Proyecto");
                });

            modelBuilder.Entity("RazorPagesIgnis.Models.Tecnico", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Apellido");

                    b.Property<string>("Nombre");

                    b.HasKey("ID");

                    b.ToTable("Tecnico");
                });
#pragma warning restore 612, 618
        }
    }
}
