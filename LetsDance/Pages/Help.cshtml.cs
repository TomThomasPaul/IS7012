using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using LetsDance.Models;  //added

namespace LetsDance.Pages
{
    public class HelpModel : PageModel
    {

        private readonly LetsDance.Data.LetsDanceContext _context; //added


        public HelpModel(LetsDance.Data.LetsDanceContext context)//added context
        {
            
            _context = context;//added

        }
        public void OnGet()
        {
        }

        [BindProperty] //added
        public Inquiry Inquiry { get; set; } //added


        public async Task<IActionResult> OnPostAsync() //added
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Inquiry.Add(Inquiry);
            await _context.SaveChangesAsync();
            TempData["successMessage"] = "Inquiry Received. We will get back to you shortly.";

            return RedirectToPage("./Index");
        }


    }
}
