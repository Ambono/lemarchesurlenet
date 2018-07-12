using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using lemarchesurlenet.Models;

namespace lemarchesurlenet.Pages
{
    public class IndexModel : PageModel
    {
        private readonly lemarchesurlenet.Models.lemarchesurlenetContext _context;

        public IndexModel(lemarchesurlenet.Models.lemarchesurlenetContext context)
        {
            _context = context;
        }

    }
}
