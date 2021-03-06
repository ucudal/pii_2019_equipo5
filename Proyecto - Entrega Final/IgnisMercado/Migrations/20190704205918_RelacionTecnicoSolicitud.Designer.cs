﻿// <auto-generated />
using System;
using IgnisMercado.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace IgnisMercado.Migrations
{
    [DbContext(typeof(ApplicationContext))]
    [Migration("20190704205918_RelacionTecnicoSolicitud")]
    partial class RelacionTecnicoSolicitud
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.4-servicing-10062");

            modelBuilder.Entity("IgnisMercado.Areas.Identity.Data.ApplicationUser", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("AccessFailedCount");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken();

                    b.Property<DateTime>("DOB");

                    b.Property<string>("Email")
                        .HasMaxLength(256);

                    b.Property<bool>("EmailConfirmed");

                    b.Property<bool>("LockoutEnabled");

                    b.Property<DateTimeOffset?>("LockoutEnd");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100);

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256);

                    b.Property<string>("PasswordHash");

                    b.Property<string>("PhoneNumber");

                    b.Property<bool>("PhoneNumberConfirmed");

                    b.Property<string>("Role")
                        .IsRequired();

                    b.Property<string>("SecurityStamp");

                    b.Property<bool>("Status");

                    b.Property<bool>("TwoFactorEnabled");

                    b.Property<string>("UserName")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasName("UserNameIndex");

                    b.ToTable("AspNetUsers");
                });

            modelBuilder.Entity("IgnisMercado.Models.Costo", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("CostoHoraAvanzado")
                        .HasColumnType("decimal(18, 2)");

                    b.Property<int>("CostoHoraBasico")
                        .HasColumnType("integer(18)");

                    b.Property<int>("HoraJornada");

                    b.Property<int>("JornadaAvanzado")
                        .HasColumnType("decimal(18, 2)");

                    b.Property<int>("JornadaBasico")
                        .HasColumnType("decimal(18, 2)");

                    b.Property<int>("PrimeraHoraAvanzado")
                        .HasColumnType("decimal(18, 2)");

                    b.Property<int>("PrimeraHoraBasico")
                        .HasColumnType("decimal(18, 2)");

                    b.HasKey("Id");

                    b.ToTable("Costos");
                });

            modelBuilder.Entity("IgnisMercado.Models.Proyecto", b =>
                {
                    b.Property<int>("ProyectoId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Descripcion")
                        .IsRequired();

                    b.Property<string>("Nombre")
                        .IsRequired();

                    b.Property<bool>("Status");

                    b.HasKey("ProyectoId");

                    b.ToTable("Proyectos");
                });

            modelBuilder.Entity("IgnisMercado.Models.RelacionClienteProyecto", b =>
                {
                    b.Property<string>("ClienteId");

                    b.Property<int>("ProyectoId");

                    b.HasKey("ClienteId", "ProyectoId");

                    b.HasIndex("ProyectoId");

                    b.ToTable("RelacionClienteProyectos");
                });

            modelBuilder.Entity("IgnisMercado.Models.RelacionProyectoSolicitud", b =>
                {
                    b.Property<int>("ProyectoId");

                    b.Property<int>("SolicitudId");

                    b.HasKey("ProyectoId", "SolicitudId");

                    b.HasIndex("SolicitudId");

                    b.ToTable("RelacionProyectoSolicitudes");
                });

            modelBuilder.Entity("IgnisMercado.Models.RelacionTecnicoRol", b =>
                {
                    b.Property<string>("TecnicoId");

                    b.Property<int>("RolId");

                    b.HasKey("TecnicoId", "RolId");

                    b.HasAlternateKey("RolId", "TecnicoId");

                    b.ToTable("RelacionTecnicoRoles");
                });

            modelBuilder.Entity("IgnisMercado.Models.RelacionTecnicoSolicitud", b =>
                {
                    b.Property<string>("TecnicoId");

                    b.Property<int>("SolicitudId");

                    b.HasKey("TecnicoId", "SolicitudId");

                    b.HasAlternateKey("SolicitudId", "TecnicoId");

                    b.ToTable("RelacionTecnicoSolicitudes");
                });

            modelBuilder.Entity("IgnisMercado.Models.Rol", b =>
                {
                    b.Property<int>("RolId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Descripcion")
                        .HasMaxLength(300);

                    b.Property<string>("Nivel")
                        .IsRequired();

                    b.HasKey("RolId");

                    b.ToTable("Roles");
                });

            modelBuilder.Entity("IgnisMercado.Models.Solicitud", b =>
                {
                    b.Property<int>("SolicitudId")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("HorasContratadas");

                    b.Property<int>("ModoDeContrato");

                    b.Property<string>("NivelExperiencia");

                    b.Property<string>("Observaciones")
                        .HasMaxLength(300);

                    b.Property<string>("RolRequerido")
                        .IsRequired()
                        .HasMaxLength(45);

                    b.Property<bool>("Status");

                    b.Property<int>("costoSolicitud")
                        .HasColumnType("decimal(18, 2)");

                    b.HasKey("SolicitudId");

                    b.ToTable("Solicitudes");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken();

                    b.Property<string>("Name")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasName("RoleNameIndex");

                    b.ToTable("AspNetRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ClaimType");

                    b.Property<string>("ClaimValue");

                    b.Property<string>("RoleId")
                        .IsRequired();

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ClaimType");

                    b.Property<string>("ClaimValue");

                    b.Property<string>("UserId")
                        .IsRequired();

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasMaxLength(128);

                    b.Property<string>("ProviderKey")
                        .HasMaxLength(128);

                    b.Property<string>("ProviderDisplayName");

                    b.Property<string>("UserId")
                        .IsRequired();

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId");

                    b.Property<string>("RoleId");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId");

                    b.Property<string>("LoginProvider")
                        .HasMaxLength(128);

                    b.Property<string>("Name")
                        .HasMaxLength(128);

                    b.Property<string>("Value");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens");
                });

            modelBuilder.Entity("IgnisMercado.Models.RelacionClienteProyecto", b =>
                {
                    b.HasOne("IgnisMercado.Areas.Identity.Data.ApplicationUser", "Cliente")
                        .WithMany("RelacionClienteProyecto")
                        .HasForeignKey("ClienteId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("IgnisMercado.Models.Proyecto", "Proyecto")
                        .WithMany("RelacionClienteProyecto")
                        .HasForeignKey("ProyectoId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("IgnisMercado.Models.RelacionProyectoSolicitud", b =>
                {
                    b.HasOne("IgnisMercado.Models.Proyecto", "Proyecto")
                        .WithMany("RelacionProyectoSolicitud")
                        .HasForeignKey("ProyectoId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("IgnisMercado.Models.Solicitud", "Solicitud")
                        .WithMany("RelacionProyectoSolicitud")
                        .HasForeignKey("SolicitudId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("IgnisMercado.Models.RelacionTecnicoRol", b =>
                {
                    b.HasOne("IgnisMercado.Models.Rol", "Rol")
                        .WithMany("RelacionTecnicoRol")
                        .HasForeignKey("RolId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("IgnisMercado.Areas.Identity.Data.ApplicationUser", "Tecnico")
                        .WithMany("RelacionTecnicoRol")
                        .HasForeignKey("TecnicoId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("IgnisMercado.Models.RelacionTecnicoSolicitud", b =>
                {
                    b.HasOne("IgnisMercado.Models.Solicitud", "Solicitud")
                        .WithMany("RelacionTecnicoSolicitud")
                        .HasForeignKey("SolicitudId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("IgnisMercado.Areas.Identity.Data.ApplicationUser", "Tecnico")
                        .WithMany("RelacionTecnicoSolicitud")
                        .HasForeignKey("TecnicoId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole")
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("IgnisMercado.Areas.Identity.Data.ApplicationUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("IgnisMercado.Areas.Identity.Data.ApplicationUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole")
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("IgnisMercado.Areas.Identity.Data.ApplicationUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("IgnisMercado.Areas.Identity.Data.ApplicationUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
