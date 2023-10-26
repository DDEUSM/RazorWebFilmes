using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using RazorWebFilmes.Data;
using RazorWebFilmes.Models;

namespace RazorWebFilmes.Pages.Movies
{
    public class IndexModel : PageModel
    {
        private readonly RazorWebFilmes.Data.RazorWebFilmesContext _context;

        public IndexModel(RazorWebFilmes.Data.RazorWebFilmesContext context)
        {
            _context = context;
        }

        public IList<Movie> Movie { get;set; } = default!;

        public async Task OnGetAsync()
        {
            if (_context.Movie != null)
            {
                Movie = await _context.Movie.ToListAsync();
            }
        }
    }
}
