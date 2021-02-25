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

namespace LetsDance.Pages.BuddingDancers
{
    public class EditModel : PageModel
    {
        private readonly LetsDance.Data.LetsDanceContext _context;

        public EditModel(LetsDance.Data.LetsDanceContext context)
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

            BuddingDancer = await _context.BuddingDancer
                .Include(b => b.Branch)
                .Include(b => b.Genre).FirstOrDefaultAsync(m => m.BuddingDancerId == id);

            if (BuddingDancer == null)
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

            int birthYear = BuddingDancer.DancerBirthDate.Year;
            int lastAllowedYear = DateTime.Now.Year - 5;
            if (birthYear > lastAllowedYear)
            {
                ModelState.AddModelError(key:"BuddingDancer.DancerBirthDate", errorMessage:"Must be older than 5 years");
            }

            if (!ModelState.IsValid)
            {
                ViewData["BranchId"] = new SelectList(_context.Branch, "BranchId", "Address");
                ViewData["GenreId"] = new SelectList(_context.Set<Genre>(), "GenreId", "GenreName");
                return Page();
            }

            _context.Attach(BuddingDancer).State = EntityState.Modified;

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
