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
    public class IndexModel : PageModel
    {
        private readonly lemarchesurlenet.Models.lemarchesurlenetContext _context;

        public IndexModel(lemarchesurlenet.Models.lemarchesurlenetContext context)
        {
            _context = context;
        }

        public IList<Partnershop> Partnershop { get;set; }

        public async Task OnGetAsync()
        {
            Partnershop = await _context.Partnershop.ToListAsync();
        }
    }
}
