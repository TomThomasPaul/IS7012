using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using LetsDance.Data;
using LetsDance.Models;

namespace LetsDance.Pages.Genres
{
    public class DetailsModel : PageModel
    {
        private readonly LetsDance.Data.LetsDanceContext _context;

        public DetailsModel(LetsDance.Data.LetsDanceContext context)
        {
            _context = context;
        }

        public Genre Genre { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Genre = await _context.Genre

                .Include(x => x.BuddingDancers)
                .FirstOrDefaultAsync(m => m.GenreId == id);

            if (Genre == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
