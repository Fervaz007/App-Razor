using AppNetRazor.Datos;
using AppNetRazor.Modelos;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace AppNetRazor.Pages.Curso
{
    public class IndexModel : PageModel
    {
        private readonly AplicationDbContext _context;

        public IndexModel(AplicationDbContext context)
        {
            _context = context;
        }

        public IEnumerable<Modelos.Curso> Cursos { get; set; }
        public async Task OnGet()
        {
            Cursos = await _context.Curso.ToListAsync();
        }
    }
}
