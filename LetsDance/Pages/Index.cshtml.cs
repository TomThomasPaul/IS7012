using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LetsDance.Data;
using LetsDance.Models;
using Microsoft.EntityFrameworkCore;



namespace LetsDance.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;
        private readonly  LetsDance.Data.LetsDanceContext _context;



        public IndexModel(ILogger<IndexModel> logger, LetsDance.Data.LetsDanceContext context)
        {
            _logger = logger;
            _context = context;
            
            
        }

       /* public void OnGet()
        {

        }*/

        public int TotalBuddingDancers { get; set; }
        public int TotalFaculties { get; set; }
        public async Task OnGetAsync()
        {
            TotalBuddingDancers = await _context.BuddingDancer.CountAsync();
            TotalFaculties = await _context.Faculty.CountAsync();

        }






    }

}

