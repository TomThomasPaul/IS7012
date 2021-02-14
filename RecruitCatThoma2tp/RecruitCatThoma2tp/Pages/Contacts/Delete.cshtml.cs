using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using RecruitCatThoma2tp.Data;
using RecruitCatThoma2tp.Models;

namespace RecruitCatThoma2tp.Pages.Contacts
{
    public class DeleteModel : PageModel
    {
        private readonly RecruitCatThoma2tp.Data.RecruitCatThoma2tpContext _context;

        public DeleteModel(RecruitCatThoma2tp.Data.RecruitCatThoma2tpContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Contact Contact { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Contact = await _context.Contact
                .Include(c => c.Candidate)
                .Include(c => c.Company).FirstOrDefaultAsync(m => m.ContactId == id);

            if (Contact == null)
            {
                return NotFound();
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Contact = await _context.Contact.FindAsync(id);

            if (Contact != null)
            {
                _context.Contact.Remove(Contact);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
