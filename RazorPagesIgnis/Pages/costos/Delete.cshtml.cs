using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Ignis;
using RazorPagesIgnis.Models;

namespace RazorPagesIgnis.Pages.costos
{
    public class DeleteModel : PageModel
    {
        private readonly RazorPagesIgnis.Models.RazorPagesIgnisContext _context;

        public DeleteModel(RazorPagesIgnis.Models.RazorPagesIgnisContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Costo Costo { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Costo = await _context.Costo.FirstOrDefaultAsync(m => m.ID == id);

            if (Costo == null)
            {
                return NotFound();
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Costo = await _context.Costo.FindAsync(id);

            if (Costo != null)
            {
                _context.Costo.Remove(Costo);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
