﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Workshop_1.Data;
using Workshop_1.Models;

namespace Workshop_1.Pages.Movies
{
    public class CreateModel : PageModel
    {
        private readonly Workshop_1.Data.Workshop_1Context _context;

        public CreateModel(Workshop_1.Data.Workshop_1Context context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public Movies Movies { get; set; } = default!;

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Movies.Add(Movies);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}