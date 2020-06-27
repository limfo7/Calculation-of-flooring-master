using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Calculator.Core.DAL
{
    public class AppDbContext: DbContext
    {
        public DbSet<Products> MyProperty { get; set; }
    }
}
