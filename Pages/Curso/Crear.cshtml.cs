using AppNetRazor.Datos;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace AppNetRazor.Pages.Curso
{
    public class CrearModel : PageModel
    {

        private readonly AplicationDbContext _context;

        public CrearModel(AplicationDbContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Modelos.Curso Curso { get; set; }

        public void OnGet()
        {
        }

        public async Task<IActionResult> OnPost()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            Curso.FechaCreacion = DateTime.Now;

            _context.Add(Curso);
            await _context.SaveChangesAsync();
            return RedirectToPage("Index");
        }
    }
}
