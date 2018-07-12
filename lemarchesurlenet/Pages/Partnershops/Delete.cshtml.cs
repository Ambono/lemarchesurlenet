using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using lemarchesurlenet.Models;

namespace lemarchesurlenet.Pages.Partnershops
{
    public class DeleteModel : PageModel
    {
        private readonly lemarchesurlenet.Models.lemarchesurlenetContext _context;

        public DeleteModel(lemarchesurlenet.Models.lemarchesurlenetContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Partnershop Partnershop { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Partnershop = await _context.Partnershop.FirstOrDefaultAsync(m => m.ID == id);

            if (Partnershop == null)
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

            Partnershop = await _context.Partnershop.FindAsync(id);

            if (Partnershop != null)
            {
                _context.Partnershop.Remove(Partnershop);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
