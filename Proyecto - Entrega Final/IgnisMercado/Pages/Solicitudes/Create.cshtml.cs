using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using IgnisMercado.Models;

namespace IgnisMercado.Pages.Solicitudes
{
    public class CreateModel : PageModel
    {
        private readonly IgnisMercado.Models.ApplicationContext _context;

        public CreateModel(IgnisMercado.Models.ApplicationContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public Solicitud Solicitud { get; set; }

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Solicitudes.Add(Solicitud);

            await _context.SaveChangesAsync();

            // se agrega la solicitud como observador.
            Costo costo = new Costo();

            costo.Agregar(Solicitud);

            return RedirectToPage("./Index");
        }
    }
}