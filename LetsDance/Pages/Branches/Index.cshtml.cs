using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using LetsDance.Data;
using LetsDance.Models;

namespace LetsDance.Pages.Branches
{
    public class IndexModel : PageModel
    {
        private readonly LetsDance.Data.LetsDanceContext _context;

        public IndexModel(LetsDance.Data.LetsDanceContext context)
        {
            _context = context;
        }

        public IList<Branch> Branch { get;set; }

        public async Task OnGetAsync()
        {
            Branch = await _context.Branch.ToListAsync();
        }
    }
}
