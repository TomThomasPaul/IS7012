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

namespace LetsDance.Pages.ClassSchedules
{
    public class EditModel : PageModel
    {
        private readonly LetsDance.Data.LetsDanceContext _context;

        public EditModel(LetsDance.Data.LetsDanceContext context)
        {
            _context = context;
        }

        [BindProperty]
        public ClassSchedule ClassSchedule { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            ClassSchedule = await _context.ClassSchedule
                .Include(c => c.BuddingDancer)
                .Include(c => c.Faculty).FirstOrDefaultAsync(m => m.ClassScheduleId == id);

            if (ClassSchedule == null)
            {
                return NotFound();
            }
           ViewData["BuddingDancerId"] = new SelectList(_context.BuddingDancer, "BuddingDancerId", "DancerFullName");
           ViewData["FacultyId"] = new SelectList(_context.Set<Faculty>(), "FacultyId", "FacultyFullName");
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

            _context.Attach(ClassSchedule).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ClassScheduleExists(ClassSchedule.ClassScheduleId))
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

        private bool ClassScheduleExists(int id)
        {
            return _context.ClassSchedule.Any(e => e.ClassScheduleId == id);
        }
    }
}
