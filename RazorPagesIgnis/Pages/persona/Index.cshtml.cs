using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Ignis;
using RazorPagesIgnis.Models;

namespace RazorPagesIgnis.Pages.persona
{
    public class IndexModel : PageModel
    {
        private readonly RazorPagesIgnis.Models.RazorPagesIgnisContext _context;

        public IndexModel(RazorPagesIgnis.Models.RazorPagesIgnisContext context)
        {
            _context = context;
        }

        public IList<Persona> Persona { get;set; }

        public async Task OnGetAsync()
        {
            Persona = await _context.Persona.ToListAsync();
        }
    }
}
