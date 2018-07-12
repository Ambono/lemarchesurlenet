using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using lemarchesurlenet.Models;

namespace lemarchesurlenet.Pages.Onlineshops
{
    public class EditModel : PageModel
    {
        private readonly lemarchesurlenet.Models.lemarchesurlenetContext _context;

        public EditModel(lemarchesurlenet.Models.lemarchesurlenetContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Onlineshop Onlineshop { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Onlineshop = await _context.Onlineshop.FirstOrDefaultAsync(m => m.ID == id);

            if (Onlineshop == null)
            {
                return NotFound();
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Attach(Onlineshop).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!OnlineshopExists(Onlineshop.ID))
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

        private bool OnlineshopExists(int id)
        {
            return _context.Onlineshop.Any(e => e.ID == id);
        }
    }
}
