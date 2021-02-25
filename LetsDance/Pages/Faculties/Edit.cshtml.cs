using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using LetsDance.Data;
using LetsDance.Models;

namespace LetsDance.Pages.Faculties
{
    public class EditModel : PageModel
    {
        private readonly LetsDance.Data.LetsDanceContext _context;

        public EditModel(LetsDance.Data.LetsDanceContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Faculty Faculty { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Faculty = await _context.Faculty
                .Include(f => f.Branch)
                .Include(f => f.Genre).FirstOrDefaultAsync(m => m.FacultyId == id);

            if (Faculty == null)
            {
                return NotFound();
            }
           ViewData["BranchId"] = new SelectList(_context.Branch, "BranchId", "Address");
           ViewData["GenreId"] = new SelectList(_context.Set<Genre>(), "GenreId", "GenreName");
            return Page();
        }

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

            _context.Attach(Faculty).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!FacultyExists(Faculty.FacultyId))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return RedirectToPage("./Index");
        }

        private bool FacultyExists(int id)
        {
            return _context.Faculty.Any(e => e.FacultyId == id);
        }
    }
}
