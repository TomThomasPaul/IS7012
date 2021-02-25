using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using LetsDance.Data;
using LetsDance.Models;

namespace LetsDance.Pages.Faculties
{
    public class DetailsModel : PageModel
    {
        private readonly LetsDance.Data.LetsDanceContext _context;

        public DetailsModel(LetsDance.Data.LetsDanceContext context)
        {
            _context = context;
        }

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
            return Page();
        }
    }
}
