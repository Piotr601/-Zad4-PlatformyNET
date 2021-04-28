using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using AplikacjaWebowa.Data;
using Zad2;

namespace AplikacjaWebowa.Pages.History
{
    public class DetailsModel : PageModel
    {
        private readonly AplikacjaWebowa.Data.AplikacjaWebowaContext _context;

        public DetailsModel(AplikacjaWebowa.Data.AplikacjaWebowaContext context)
        {
            _context = context;
        }

        public Currency Currency { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Currency = await _context.Currency.FirstOrDefaultAsync(m => m.ID == id);

            if (Currency == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
