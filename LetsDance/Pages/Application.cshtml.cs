using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace LetsDance.Pages
{
    public class ApplicationModel : PageModel
    {
        public void OnGet()
        {
        }
        public IActionResult OnPostSubmissionAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }
            TempData["notice"] = " Registered Successfully ";
            return RedirectToPage("/Application");
        }
    }
}
