using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using RazorMovies.Models;
using RazorMovies.Data;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace RazorMovies.Pages.Directors
{
    public class IndexModel : PageModel
    {
        private readonly RazorMoviesContext _context;

        public IndexModel(RazorMoviesContext context)
        {
            _context = context;
        }

        public IList<Director> Director { get;set; }

        public async Task OnGetAsync()
        {
            Director = await _context.Director.ToListAsync();
        }
    }
}
