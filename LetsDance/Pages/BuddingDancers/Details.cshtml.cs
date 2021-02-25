using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using LetsDance.Data;
using LetsDance.Models;

namespace LetsDance.Pages.BuddingDancers
{
    public class DetailsModel : PageModel
    {
        private readonly LetsDance.Data.LetsDanceContext _context;

        public DetailsModel(LetsDance.Data.LetsDanceContext context)
        {
            _context = context;
        }

        public BuddingDancer BuddingDancer { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            BuddingDancer = await _context.BuddingDancer
                .Include(b => b.Branch)
                .Include(b => b.Genre).FirstOrDefaultAsync(m => m.BuddingDancerId == id);

            if (BuddingDancer == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
