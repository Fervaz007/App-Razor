using AppNetRazor.Datos;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace AppNetRazor.Pages.Curso
{
    public class EditarModel : PageModel
    {
        private readonly AplicationDbContext _context;

        public EditarModel(AplicationDbContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Modelos.Curso Curso { get; set; }

        public async Task OnGet(int id)
        {
            Curso = await _context.Curso.FindAsync(id);
        }

        public async Task<IActionResult> OnPost()
        {
            if (ModelState.IsValid)
            {
                var CursoDesdeBD = await _context.Curso.FindAsync(Curso.Id);
                CursoDesdeBD.NombreCurso = Curso.NombreCurso;
                CursoDesdeBD.CantidadClases = Curso.CantidadClases;
                CursoDesdeBD.Precio = Curso.Precio;

                await _context.SaveChangesAsync();
                return RedirectToPage("Index");
            }

            return RedirectToPage("");
        }
    }
}
