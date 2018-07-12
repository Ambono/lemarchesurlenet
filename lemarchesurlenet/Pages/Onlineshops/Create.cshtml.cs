using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using lemarchesurlenet.Models;

namespace lemarchesurlenet.Pages.Onlineshops
{
    public class CreateModel : PageModel
    {
        private readonly lemarchesurlenet.Models.lemarchesurlenetContext _context;

        public CreateModel(lemarchesurlenet.Models.lemarchesurlenetContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public Onlineshop Onlineshop { get; set; }

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Onlineshop.Add(Onlineshop);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}