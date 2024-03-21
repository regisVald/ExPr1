using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using ExamenPracticoDS39.Data;
using ExamenPracticoDS39.Models;

namespace ExamenPracticoDS39.Pages.Supplier
{
    public class DetailsModel : PageModel
    {
        private readonly ExamenPracticoDS39.Data.ExamenPracticoDS39Context _context;

        public DetailsModel(ExamenPracticoDS39.Data.ExamenPracticoDS39Context context)
        {
            _context = context;
        }

      public Models.Supplier Supplier { get; set; } = default!; 

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null || _context.Supplier == null)
            {
                return NotFound();
            }

            var supplier = await _context.Supplier.FirstOrDefaultAsync(m => m.SupplierId == id);
            if (supplier == null)
            {
                return NotFound();
            }
            else 
            {
                Supplier = supplier;
            }
            return Page();
        }
    }
}
