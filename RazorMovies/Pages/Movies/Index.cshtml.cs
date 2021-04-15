using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using RazorMovies.Data;
using RazorMovies.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RazorMovies.Pages.Movies
{
    public class IndexModel : PageModel
    {
        private readonly RazorMoviesContext _context;
        public IList<Movie> Movie { get;set; }

        public IndexModel(RazorMoviesContext context)
        {
            _context = context;
        }

        public async Task OnGetAsync(string searchString)
        {
            IQueryable<Movie> movies = from m in _context.Movie
                                       select m;

            if (!String.IsNullOrEmpty(searchString))
            {
                movies = movies.Where(m => m.Name.Contains(searchString));
            }

            Movie = await movies.ToListAsync();
        }
    }
}
