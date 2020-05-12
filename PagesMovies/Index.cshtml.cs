using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using DND_Warlock.Data;
using DND_Warlock.Models;

namespace DND_Warlock.PagesMovies
{
    public class IndexModel : PageModel
    {
        private readonly DND_Warlock.Data.DND_WarlockContext _context;

        public IndexModel(DND_Warlock.Data.DND_WarlockContext context)
        {
            _context = context;
        }

        public IList<Movie> Movie { get;set; }

        public async Task OnGetAsync()
        {
            Movie = await _context.Movie.ToListAsync();
        }
    }
}
