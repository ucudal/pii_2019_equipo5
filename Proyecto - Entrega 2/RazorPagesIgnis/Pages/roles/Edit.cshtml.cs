using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using RazorPagesIgnis;
using RazorPagesIgnis.Models;

namespace RazorPagesIgnis.Pages.roles
{
    public class EditModel : PageModel
    {
        private readonly RazorPagesIgnis.Models.RazorPagesIgnisContext _context;

        public EditModel(RazorPagesIgnis.Models.RazorPagesIgnisContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Rol Rol { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Rol = await _context.Rol.FirstOrDefaultAsync(m => m.ID == id);

            if (Rol == null)
            {
                return NotFound();
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Attach(Rol).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!RolExists(Rol.ID))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return RedirectToPage("./Index");
        }

        private bool RolExists(int id)
        {
            return _context.Rol.Any(e => e.ID == id);
        }
    }
}
