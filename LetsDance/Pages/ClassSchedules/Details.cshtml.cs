using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using LetsDance.Data;
using LetsDance.Models;

namespace LetsDance.Pages.ClassSchedules
{
    public class DetailsModel : PageModel
    {
        private readonly LetsDance.Data.LetsDanceContext _context;

        public DetailsModel(LetsDance.Data.LetsDanceContext context)
        {
            _context = context;
        }

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
            return Page();
        }
    }
}
