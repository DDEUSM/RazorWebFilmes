using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using RazorWebFilmes.Models;

namespace RazorWebFilmes.Data
{
    public class RazorWebFilmesContext : DbContext
    {
        public RazorWebFilmesContext (DbContextOptions<RazorWebFilmesContext> options)
            : base(options)
        {
        }

        public DbSet<RazorWebFilmes.Models.Movie> Movie { get; set; } = default!;
    }
}
