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
    public class DetailsModel : PageModel
    {
        private readonly lemarchesurlenet.Models.lemarchesurlenetContext _context;

        public DetailsModel(lemarchesurlenet.Models.lemarchesurlenetContext context)
        {
            _context = context;
        }

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
    }
}
