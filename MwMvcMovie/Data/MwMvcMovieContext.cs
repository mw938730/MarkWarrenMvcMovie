using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MvcMovie.Models;

namespace MwMvcMovie.Models
{
    public class MwMvcMovieContext : DbContext
    {
        public MwMvcMovieContext (DbContextOptions<MwMvcMovieContext> options)
            : base(options)
        {
        }

        public DbSet<MvcMovie.Models.Movie> Movie { get; set; }
    }
}
