using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Workshop_1.Models;

namespace Workshop_1.Data
{
    public class Workshop_1Context : DbContext
    {
        public Workshop_1Context (DbContextOptions<Workshop_1Context> options)
            : base(options)
        {
        }

        public DbSet<Workshop_1.Models.Movies> Movies { get; set; } = default!;
    }
}
