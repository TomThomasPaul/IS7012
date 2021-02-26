  using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using LetsDance.Data;
using LetsDance.Models;

namespace LetsDance.Pages.Inquiries
{
    public class EditModel : PageModel
    {
        private readonly LetsDance.Data.LetsDanceContext _context;

        public EditModel(LetsDance.Data.LetsDanceContext context)
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

        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Attach(Inquiry).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!InquiryExists(Inquiry.InquiryId))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return RedirectToPage("./Index");
        }

        private bool InquiryExists(int id)
        {
            return _context.Inquiry.Any(e => e.InquiryId == id);
        }
    }
}
