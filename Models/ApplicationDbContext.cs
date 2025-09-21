using Microsoft.EntityFrameworkCore;
using System.Diagnostics;

namespace ASP.NET_MVC_Machine_Test.Models
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
             : base(options)
        {
        }
        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }
    }
}
