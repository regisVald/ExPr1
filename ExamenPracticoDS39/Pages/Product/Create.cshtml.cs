using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using ExamenPracticoDS39.Data;
using ExamenPracticoDS39.Models;
using Microsoft.AspNetCore.Mvc.ViewFeatures;

namespace ExamenPracticoDS39.Pages.Product
{
    public class CreateModel : PageModel
    {
        private readonly ExamenPracticoDS39.Data.ExamenPracticoDS39Context _context;

        public CreateModel(ExamenPracticoDS39.Data.ExamenPracticoDS39Context context)
        {
            _context = context;
        }

        [BindProperty]
        public Models.Products Products { get; set; }

        public IList<SelectListItem> Categories { get; set; }
        public IList<SelectListItem> Suppliers { get; set; }

        public IActionResult OnGet()
        {
            Categories = _context.Category
                .Select(c => new SelectListItem
                {
                    Value = c.CategoryId.ToString(),
                    Text = c.CategoryName
                }).ToList();

            Suppliers = _context.Supplier
            .Select(s => new SelectListItem
            {
                Value = s.SupplierId.ToString(),
                Text = s.CompanyName
            }).ToList();

            return Page();
        }



        public async Task<IActionResult> OnPostAsync()
        {
            if (ModelState.IsValid)
            {
                return Page();
            }

            _context.Products.Add(Products);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
