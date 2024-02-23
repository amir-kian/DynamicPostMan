using DynamicPostMan.Models;
using Microsoft.EntityFrameworkCore;

namespace DynamicPostMan.Infrustructure
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        public DbSet<User> Users { get; set; }
    }
}
