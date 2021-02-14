using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using RecruitCatThoma2tp.Data;
using RecruitCatThoma2tp.Models;

namespace RecruitCatThoma2tp.Pages.Candidates
{
    public class CreateModel : PageModel
    {
        private readonly RecruitCatThoma2tp.Data.RecruitCatThoma2tpContext _context;

        public CreateModel(RecruitCatThoma2tp.Data.RecruitCatThoma2tpContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
        ViewData["CompanyId"] = new SelectList(_context.Set<Company>(), "CompanyId", "CompanyName"); //changing value in the key value pair to company name
        ViewData["IndustryId"] = new SelectList(_context.Set<Industry>(), "IndustryId", "IndustryName"); //changing value in the key value pair to industry name
            ViewData["JobTitleId"] = new SelectList(_context.Set<JobTitle>(), "JobTitleId", "JobTitleName"); //changing value in the key value pair to jobtitle name
            return Page();
        }

        [BindProperty]
        public Candidate Candidate { get; set; }

        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Candidate.Add(Candidate);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
