using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using LetsDance.Data;
using LetsDance.Models;
using Microsoft.EntityFrameworkCore;

namespace LetsDance.Pages.BuddingDancers
{
    public class UpdateModel : PageModel
    {
        private readonly LetsDance.Data.LetsDanceContext _context;

        public UpdateModel(LetsDance.Data.LetsDanceContext context)
        {
            _context = context;
        }


        [BindProperty]
        public BuddingDancer BuddingDancer { get; set; }
        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }


            BuddingDancer = await _context.BuddingDancer.FirstOrDefaultAsync(m => m.BuddingDancerId == id);

            if (BuddingDancer == null)
            {
                return NotFound();
            }


            return Page();
        }


        public async Task<IActionResult> OnPostAsync()
        {

            var dancer = await _context.BuddingDancer.FindAsync(BuddingDancer.BuddingDancerId);

            dancer.PastStudent = !dancer.PastStudent;



            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!BuddingDancerExists(BuddingDancer.BuddingDancerId))
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

        private bool BuddingDancerExists(int id)
        {
            return _context.BuddingDancer.Any(e => e.BuddingDancerId == id);
        }

    }
}
