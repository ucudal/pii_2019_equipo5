using System;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using RazorPagesIgnis.Models;

namespace RazorPagesIgnis
{
    /// <summary>
    /// Esta clase nos permite inicializar la base de datos luego de creada, 
    /// agregando valores por defecto. En todos los casos solo se agregan valores 
    /// si no hay registros previos en la tabla.
    /// </summary>
    public static class SeeData 
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var contexto = new RazorPagesIgnisContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<RazorPagesIgnisContext>>()))
            {
                SeedAdministradores(contexto);
                SeedClientes(contexto);
                SeedTecnicos(contexto);
                SeedSolicitudes(contexto);
                SeedTecnicoSolicitudes(contexto);
                SeedProyectos(contexto);
                SeedRoles(contexto);
            }
        }

        /// <summary>
        /// Seeding Administrador.
        /// </summary>
        private static void SeedAdministradores(RazorPagesIgnisContext contexto)
        {
            if (contexto.Administradores.Any()) 
            {
                return;
            }

            contexto.Administradores.AddRange(
                new Administrador 
                {
                    Nombre = "Marcelo",
                    Correo = "marce@correo.com", 
                    Contrasena = "********"
                },

                new Administrador 
                {
                    Nombre = "Alvaro",
                    Correo = "elalvaro@correo.com", 
                    Contrasena = "********"
                }
            );
            contexto.SaveChanges();
        }

        /// <summary>
        /// Seeding Cliente.
        /// </summary>
        private static void SeedClientes(RazorPagesIgnisContext contexto)
        {
            if (contexto.Clientes.Any()) 
            {
                return;
            }

            contexto.Clientes.AddRange(
                new Cliente 
                {
                    Nombre = "Micaela",
                    Correo = "mica@correo.com", 
                    Contrasena = "********"
                },

                new Cliente 
                {
                    Nombre = "Roberto",
                    Correo = "roberto@correo.com", 
                    Contrasena = "********"
                }
            );
            contexto.SaveChanges();
        }

        /// <summary>
        /// Seeding Técnico.
        /// </summary>
        private static void SeedTecnicos(RazorPagesIgnisContext contexto)
        {
            if (contexto.Tecnicos.Any()) 
            {
                return;
            }

            contexto.Tecnicos.AddRange(
                new Tecnico 
                {
                    Nombre = "Marcelo",
                    Correo = "marce@correo.com", 
                    Contrasena = "********", 
                    Edad = 40,
                    Presentacion = "Hola!", 
                    Nivel_experiencia = "Básico"
                },

                new Tecnico 
                {
                    Nombre = "Laura",
                    Correo = "laura@correo.com", 
                    Contrasena = "********", 
                    Edad = 25,
                    Presentacion = "Buen día!", 
                    Nivel_experiencia = "Avanzado"
                },

                new Tecnico 
                {
                    Nombre = "Diego",
                    Correo = "eldiego@correo.com", 
                    Contrasena = "********", 
                    Edad = 22,
                    Presentacion = "Buenas tardes!", 
                    Nivel_experiencia = "Básico"
                }
            );
            contexto.SaveChanges();
        }

        /// <summary>
        /// Seeding Solicitud.
        /// </summary>
        private static void SeedSolicitudes(RazorPagesIgnisContext contexto)
        {
            if (contexto.Solicitudes.Any()) 
            {
                return;
            }

            contexto.Solicitudes.AddRange(
                new Solicitud 
                {
                    ModoDeContrato = 1, 
                    RolRequerido = "Camarografo", 
                    HorasContratadas = 8, 
                    NivelExperiencia = "Básico", 
                    Observaciones = "obs..."
                },

                new Solicitud 
                {
                    ModoDeContrato = 2, 
                    RolRequerido = "Luces", 
                    HorasContratadas = 10, 
                    NivelExperiencia = "Avanzado", 
                    Observaciones = "no."
                },

                new Solicitud 
                {
                    ModoDeContrato = 1, 
                    RolRequerido = "Director", 
                    HorasContratadas = 15, 
                    NivelExperiencia = "Básico", 
                    Observaciones = "no."
                }
            );
            contexto.SaveChanges();
        }

        /// <summary>
        /// Seeding TecnicoSolicitud.
        /// </summary>
        private static void SeedTecnicoSolicitudes(RazorPagesIgnisContext contexto)
        {
            if (contexto.TecnicoSolicitudes.Any()) 
            {
                return;
            }

            var tecnicoSolictudes = new TecnicoSolicitud[]
            {
                new TecnicoSolicitud 
                {
                    tecnicoID = contexto.Tecnicos.Single(t => t.Nombre == "Marcelo").ID, 
                    solicitudID = contexto.Solicitudes.Single(s => s.ID == 1).ID 
                },

                new TecnicoSolicitud 
                {
                    tecnicoID = contexto.Tecnicos.Single(t => t.Nombre == "Marcelo").ID, 
                    solicitudID = contexto.Solicitudes.Single(s => s.ID == 3).ID 
                },

                new TecnicoSolicitud 
                {
                    tecnicoID = contexto.Tecnicos.Single(t => t.Nombre == "Laura").ID, 
                    solicitudID = contexto.Solicitudes.Single(s => s.ID == 2).ID 
                }
            };

            foreach (TecnicoSolicitud ts in tecnicoSolictudes)
            {
                contexto.TecnicoSolicitudes.Add(ts);
            }

            contexto.SaveChanges();
        }

        /// <summary>
        /// Seeding Proyecto.
        /// </summary>
        private static void SeedProyectos(RazorPagesIgnisContext contexto)
        {
            if (contexto.Proyectos.Any()) 
            {
                return;
            }

            contexto.Proyectos.AddRange(
                new Proyecto 
                {
                    Nombre = "Hulk Aplasta!!!", 
                    Descripcion = "El héroe verde regresa... más enojado que nunca!"
                },

                new Proyecto 
                {
                    Nombre = "Docu-mental",
                    Descripcion = "Investigación." 
                }
            );
            contexto.SaveChanges();
        }

        /// <summary>
        /// Seeding Rol.
        /// </summary>
        private static void SeedRoles(RazorPagesIgnisContext contexto)
        {
            if (contexto.Roles.Any()) 
            {
                return;
            }

            contexto.Roles.AddRange(
                new Rol 
                {
                    Nombre = "Cámara", 
                    Descripcion = "."
                },

                new Rol 
                {
                    Nombre = "Luces", 
                    Descripcion = ".."
                },

                new Rol 
                {
                    Nombre = "Director",
                    Descripcion = "..." 
                }
            );
            contexto.SaveChanges();
        }
    }
}
