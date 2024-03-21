using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using ExamenPracticoDS39.Data;
using ExamenPracticoDS39.Models;

namespace ExamenPracticoDS39.Pages.Supplier
{
    public class CreateModel : PageModel
    {
        private readonly ExamenPracticoDS39.Data.ExamenPracticoDS39Context _context;

        public CreateModel(ExamenPracticoDS39.Data.ExamenPracticoDS39Context context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public Models.Supplier Supplier { get; set; } = default!;
        

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
          if (!ModelState.IsValid || _context.Supplier == null || Supplier == null)
            {
                return Page();
            }

            _context.Supplier.Add(Supplier);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
