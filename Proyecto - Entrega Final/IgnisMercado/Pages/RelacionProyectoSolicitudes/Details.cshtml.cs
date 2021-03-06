using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using IgnisMercado.Models;

namespace IgnisMercado.Pages.RelacionProyectoSolicitudes
{
    public class DetailsModel : PageModel
    {
        private readonly IgnisMercado.Models.ApplicationContext _context;

        public DetailsModel(IgnisMercado.Models.ApplicationContext context)
        {
            _context = context;
        }

        public RelacionProyectoSolicitud RelacionProyectoSolicitud { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            RelacionProyectoSolicitud = await _context.RelacionProyectoSolicitudes
                .Include(r => r.Proyecto)
                .Include(r => r.Solicitud).FirstOrDefaultAsync(m => m.ProyectoId == id);

            if (RelacionProyectoSolicitud == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
