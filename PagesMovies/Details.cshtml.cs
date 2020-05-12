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
    public class DetailsModel : PageModel
    {
        private readonly DND_Warlock.Data.DND_WarlockContext _context;

        public DetailsModel(DND_Warlock.Data.DND_WarlockContext context)
        {
            _context = context;
        }

        public Movie Movie { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Movie = await _context.Movie.FirstOrDefaultAsync(m => m.ID == id);

            if (Movie == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
