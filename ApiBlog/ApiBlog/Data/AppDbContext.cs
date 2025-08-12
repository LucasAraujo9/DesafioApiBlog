using ApiBlog.Models;
using Microsoft.EntityFrameworkCore;

namespace ApiBlog.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> opt) : base(opt) { }

        public DbSet<BlogPost> BlogPost { get; set; }
        public DbSet<Comment> Comment { get; set; }
    }
}
