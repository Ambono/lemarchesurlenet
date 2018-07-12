using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using lemarchesurlenet.Models;

namespace lemarchesurlenet.Pages.Onlineshops
{
    public class DetailsModel : PageModel
    {
        private readonly lemarchesurlenet.Models.lemarchesurlenetContext _context;

        public DetailsModel(lemarchesurlenet.Models.lemarchesurlenetContext context)
        {
            _context = context;
        }

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
    }
}
