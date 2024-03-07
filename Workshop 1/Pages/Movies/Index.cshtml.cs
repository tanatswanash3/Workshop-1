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
    public class IndexModel : PageModel
    {
        private readonly Workshop_1.Data.Workshop_1Context _context;

        public IndexModel(Workshop_1.Data.Workshop_1Context context)
        {
            _context = context;
        }

        public IList<Movies> Movies { get;set; } = default!;

        public async Task OnGetAsync()
        {
            Movies = await _context.Movies.ToListAsync();
        }
    }
}
