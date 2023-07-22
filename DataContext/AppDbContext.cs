using DatingApp.Models;
using Microsoft.EntityFrameworkCore;

namespace DatingApp.DataContext
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions options) : base(options)
        {

        }
        public DbSet<User> Users { get; set; }
    }
}
