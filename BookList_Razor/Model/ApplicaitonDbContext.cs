using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookList_Razor.Model
{
    public class ApplicaitonDbContext: DbContext
    {
        public ApplicaitonDbContext (DbContextOptions<ApplicaitonDbContext> options) : base(options)
        {

        }

        public DbSet<Book> Books { get; set; }
            
      }
}
