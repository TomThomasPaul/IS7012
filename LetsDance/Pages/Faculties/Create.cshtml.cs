using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using LetsDance.Data;
using LetsDance.Models;

namespace LetsDance.Pages.Faculties
{
    public class CreateModel : PageModel
    {
        private readonly LetsDance.Data.LetsDanceContext _context;

        public CreateModel(LetsDance.Data.LetsDanceContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
        ViewData["BranchId"] = new SelectList(_context.Branch, "BranchId", "Address");
        ViewData["GenreId"] = new SelectList(_context.Set<Genre>(), "GenreId", "GenreName");
            return Page();
        }

        [BindProperty]
        public Faculty Faculty { get; set; }

        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Faculty.Add(Faculty);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
