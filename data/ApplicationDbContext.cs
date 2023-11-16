using Microsoft.EntityFrameworkCore;
using MovieWebAPI.Models;
using System.Security.Cryptography.X509Certificates;

namespace MovieWebAPI.Data
{
    public class ApplicationDbContext : DbContext
    {
        public DbSet<Movie> movies { get; set; }
        public ApplicationDbContext(DbContextOptions options) : base(options)
        {
            
        }
    }
}
