﻿using System;
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
    public class IndexModel : PageModel
    {
        private readonly ExamenPracticoDS39.Data.ExamenPracticoDS39Context _context;

        public IndexModel(ExamenPracticoDS39.Data.ExamenPracticoDS39Context context)
        {
            _context = context;
        }

        public IList<Models.Supplier> Supplier { get;set; } = default!;

        public async Task OnGetAsync()
        {
            if (_context.Supplier != null)
            {
                Supplier = await _context.Supplier.ToListAsync();
            }
        }
    }
}
