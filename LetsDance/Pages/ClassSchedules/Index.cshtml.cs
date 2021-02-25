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
    public class IndexModel : PageModel
    {
        private readonly LetsDance.Data.LetsDanceContext _context;

        public IndexModel(LetsDance.Data.LetsDanceContext context)
        {
            _context = context;
        }

        public IList<ClassSchedule> ClassSchedule { get;set; }

        public async Task OnGetAsync()
        {
            ClassSchedule = await _context.ClassSchedule
                .Include(c => c.BuddingDancer)
                .Include(c => c.Faculty).ToListAsync();
        }
    }
}
