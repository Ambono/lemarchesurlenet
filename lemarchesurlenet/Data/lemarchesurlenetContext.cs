using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using lemarchesurlenet.Models;

namespace lemarchesurlenet.Models
{
    public class lemarchesurlenetContext : DbContext
    {
        public lemarchesurlenetContext (DbContextOptions<lemarchesurlenetContext> options)
            : base(options)
        {
        }

        public DbSet<lemarchesurlenet.Models.Student> Student { get; set; }     

        public DbSet<lemarchesurlenet.Models.Onlineshop> Onlineshop { get; set; }

        public DbSet<lemarchesurlenet.Models.Partnershop> Partnershop { get; set; }

    }
}
