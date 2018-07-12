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
    public class IndexModel : PageModel
    {
        private readonly lemarchesurlenet.Models.lemarchesurlenetContext _context;

        public IndexModel(lemarchesurlenet.Models.lemarchesurlenetContext context)
        {
            _context = context;
        }

        public IList<Onlineshop> Onlineshop { get;set; }

        public async Task OnGetAsync()
        {
            Onlineshop = await _context.Onlineshop.ToListAsync();
        }
    }
}
