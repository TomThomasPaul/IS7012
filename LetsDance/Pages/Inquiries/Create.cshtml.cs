using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using LetsDance.Data;
using LetsDance.Models;

namespace LetsDance.Pages.Inquiries
{
    public class CreateModel : PageModel
    {
        private readonly LetsDance.Data.LetsDanceContext _context;

        public CreateModel(LetsDance.Data.LetsDanceContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public Inquiry Inquiry { get; set; }

        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Inquiry.Add(Inquiry);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
