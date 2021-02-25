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
    public class IndexModel : PageModel
    {
        private readonly LetsDance.Data.LetsDanceContext _context;

        public IndexModel(LetsDance.Data.LetsDanceContext context)
        {
            _context = context;
        }

        public IList<Faculty> Faculty { get;set; }

        public async Task OnGetAsync()
        {
            Faculty = await _context.Faculty
                .Include(f => f.Branch)
                .Include(f => f.Genre).ToListAsync();
        }
    }
}
