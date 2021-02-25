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

            decimal? facultySalary = Faculty.Salary;
            decimal minimunSalary = 20000;
            if (facultySalary < minimunSalary)
            {
                ModelState.AddModelError(key: "Faculty.Salary", errorMessage: "Annual salary should be more than the minimum salary amount i.e 20000");
            }

            if (!ModelState.IsValid)
            {
                ViewData["BranchId"] = new SelectList(_context.Branch, "BranchId", "Address");
                ViewData["GenreId"] = new SelectList(_context.Set<Genre>(), "GenreId", "GenreName");
                return Page();
            }

            decimal? facultyExperience = Faculty.Experience;
            decimal minimumExperience = 5;
            if (facultyExperience < minimumExperience)
            {
                ModelState.AddModelError(key: "Faculty.Experience", errorMessage: "Faculty should have at least 5 years of dance experience");
            }

            if (!ModelState.IsValid)
            {
                ViewData["BranchId"] = new SelectList(_context.Branch, "BranchId", "Address");
                ViewData["GenreId"] = new SelectList(_context.Set<Genre>(), "GenreId", "GenreName");
                return Page();
            }

            _context.Faculty.Add(Faculty);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
