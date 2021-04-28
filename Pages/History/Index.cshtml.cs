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
    public class IndexModel : PageModel
    {
        private readonly AplikacjaWebowa.Data.AplikacjaWebowaContext _context;

        public IndexModel(AplikacjaWebowa.Data.AplikacjaWebowaContext context)
        {
            _context = context;
        }

        public IList<Currency> Currency { get;set; }

        public async Task OnGetAsync()
        {
            Currency = await _context.Currency.ToListAsync();
        }
    }
}
