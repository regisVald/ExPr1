using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using ExamenPracticoDS39.Data;
using ExamenPracticoDS39.Models;

namespace ExamenPracticoDS39.Pages.Product
{
    public class DetailsModel : PageModel
    {
        private readonly ExamenPracticoDS39.Data.ExamenPracticoDS39Context _context;

        public DetailsModel(ExamenPracticoDS39.Data.ExamenPracticoDS39Context context)
        {
            _context = context;
        }

      public Products Products { get; set; } = default!; 

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null || _context.Products == null)
            {
                return NotFound();
            }

            var products = await _context.Products.FirstOrDefaultAsync(m => m.ProductId == id);
            if (products == null)
            {
                return NotFound();
            }
            else 
            {
                Products = products;
            }
            return Page();
        }
    }
}
