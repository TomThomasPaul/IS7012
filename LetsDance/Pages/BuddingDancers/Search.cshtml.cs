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
    public class SearchModel : PageModel
    {
        private readonly LetsDance.Data.LetsDanceContext _context;

        public SearchModel(LetsDance.Data.LetsDanceContext context)
        {
            _context = context;
        }

        public IList<BuddingDancer> BuddingDancer { get; set; }
        public bool SearchDone { get; set; }
        public string SearchTerm { get; set; }


        public async Task OnGetAsync(string searchterm)
        {
            SearchTerm = searchterm;
            if (!string.IsNullOrWhiteSpace(searchterm))
            {
                SearchDone = true;

                BuddingDancer = await _context.BuddingDancer
                        .Where(x => x.DancerLastName.StartsWith(searchterm))
                        .ToListAsync();
            }
            else
            {
                SearchDone = false;
                BuddingDancer = new List<BuddingDancer>();
            }

        }
    }
}
