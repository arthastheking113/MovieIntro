using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MovieIntro.Models;
using Microsoft.EntityFrameworkCore;
namespace MovieIntro.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Movie> Movies { get; set; }
    }
}
