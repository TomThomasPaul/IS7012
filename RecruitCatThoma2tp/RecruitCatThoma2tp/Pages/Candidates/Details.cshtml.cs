using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using RecruitCatThoma2tp.Data;
using RecruitCatThoma2tp.Models;

namespace RecruitCatThoma2tp.Pages.Candidates
{
    public class DetailsModel : PageModel
    {
        private readonly RecruitCatThoma2tp.Data.RecruitCatThoma2tpContext _context;

        public DetailsModel(RecruitCatThoma2tp.Data.RecruitCatThoma2tpContext context)
        {
            _context = context;
        }

        public Candidate Candidate { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Candidate = await _context.Candidate
                .Include(c => c.Company)
                .Include(c => c.Industry)
                .Include(c => c.JobTitle).FirstOrDefaultAsync(m => m.CandidateId == id);

            if (Candidate == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
