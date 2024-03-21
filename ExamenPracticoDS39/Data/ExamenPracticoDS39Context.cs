using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ExamenPracticoDS39.Models;

namespace ExamenPracticoDS39.Data
{
    public class ExamenPracticoDS39Context : DbContext
    {
        internal IEnumerable<object> Suppliers;

        public ExamenPracticoDS39Context (DbContextOptions<ExamenPracticoDS39Context> options)
            : base(options)
        {
        }

        public DbSet<ExamenPracticoDS39.Models.Supplier> Supplier { get; set; } = default!;

        public DbSet<ExamenPracticoDS39.Models.Category> Category { get; set; } = default!;

        public DbSet<ExamenPracticoDS39.Models.Products> Products { get; set; } = default!;
    }
}
