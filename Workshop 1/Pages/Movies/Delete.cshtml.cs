using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Workshop_1.Data;
using Workshop_1.Models;

namespace Workshop_1.Pages.Movies
{
    public class DeleteModel : PageModel
    {
        private readonly Workshop_1.Data.Workshop_1Context _context;

        public DeleteModel(Workshop_1.Data.Workshop_1Context context)
        {
            _context = context;
        }

        [BindProperty]
        public Models.Movies Movies { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var movies = await _context.Movies.FirstOrDefaultAsync(m => m.Id == id);

            if (movies == null)
            {
                return NotFound();
            }
            else
            {
                Movies = movies;
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var movies = await _context.Movies.FindAsync(id);
            if (movies != null)
            {
                Movies = movies;
                _context.Movies.Remove(Movies);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
