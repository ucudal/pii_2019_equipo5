using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

using IgnisMercado.Models;
using IgnisMercado.Areas.Identity.Data;
using IgnisMercado.Models.ClienteViewModels;

namespace IgnisMercado.Pages.Usuarios
{
    public class IndexModel : PageModel
    {
        private readonly IgnisMercado.Models.ApplicationContext _context;

        private readonly UserManager<ApplicationUser> _userManager;

        public IndexModel(IgnisMercado.Models.ApplicationContext context, UserManager<ApplicationUser> userManager)
        {
            _context = context;

            _userManager = userManager;
        }

        public string ClienteId { get; set; }

        public int ProyectoId { get; set; }

        public ClienteIndexData ClienteIdxData  { get; set; }

        public async Task OnGetAsync(string id, int? proyectoId)
        { 
            ClienteIdxData = new ClienteIndexData();

            // Mostrar los usuarios.
            ClienteIdxData.Usuarios = await _context.Users
                .OrderBy(u => u.Name)
                .OrderBy(u => u.Role)
                    .ToListAsync();

            // Seleccionar un usuario, mostrar proyectos.
            if (id != null)
            {
                // El id del usuario es el id ingresado.
                ClienteId = id;

                // Instanciar un nuevo usuario y asignarle la info a partir del viewmodel.
                ApplicationUser Usuario = ClienteIdxData.Usuarios.Where(u => u.ClienteId == id).Single();

                // Cargamos los proyectos a partir de las relaciones de ese usuario.
                ClienteIdxData.Proyectos = Usuario.RelacionClienteProyecto.Select(r => r.Proyecto);
            };

            // Seleccionar un proyecto, mostrar solicitudes.
            if (proyectoId != null)
            {
                ClienteIdxData.Solicitudes = await _context.Solicitudes
                        //.Include(p => p.RelacionClienteProyecto.Where(r => r.ClienteId == id))
                    .OrderBy(s => s.RolRequerido)
                    .OrderByDescending(s => s.NivelExperiencia)
                        .ToListAsync();
            };

        }
    }
}
