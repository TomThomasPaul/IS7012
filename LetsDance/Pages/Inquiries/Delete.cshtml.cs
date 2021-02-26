using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using LetsDance.Data;
using LetsDance.Models;

namespace LetsDance.Pages.Inquiries
{
    public class DeleteModel : PageModel
    {
        private readonly LetsDance.Data.LetsDanceContext _context;

        public DeleteModel(LetsDance.Data.LetsDanceContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Inquiry Inquiry { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Inquiry = await _context.Inquiry.FirstOrDefaultAsync(m => m.InquiryId == id);

            if (Inquiry == null)
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

            Inquiry = await _context.Inquiry.FindAsync(id);

            if (Inquiry != null)
            {
                _context.Inquiry.Remove(Inquiry);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
