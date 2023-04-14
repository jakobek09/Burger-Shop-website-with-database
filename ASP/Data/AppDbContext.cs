using Microsoft.EntityFrameworkCore;
using ASP.Models;

namespace ASP.Data
{
    public class AppDbContext : DbContext
    {
        public DbSet<Order> Orders { get; set; }
        public DbSet<Logins> Logins { get; set; }

        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
            
        }
    }
}
