using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using IgnisMercado.Models;

namespace IgnisMercado.Pages.Administradores
{
    public class DetailsModel : PageModel
    {
        private readonly IgnisMercado.Models.ApplicationContext _context;

        public DetailsModel(IgnisMercado.Models.ApplicationContext context)
        {
            _context = context;
        }

        public Administrador Administrador { get; set; }

        public async Task<IActionResult> OnGetAsync(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Administrador = await _context.Administradores.FirstOrDefaultAsync(m => m.Id == id);

            if (Administrador == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
