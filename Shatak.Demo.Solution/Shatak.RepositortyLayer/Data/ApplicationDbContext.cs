using Microsoft.EntityFrameworkCore;
using Shatak.CoreLayer.Models;

namespace Shatak.RepositortyLayer.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions options) : base(options)
        {
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            

        }

        public DbSet<Address> Addresses { get; set; }
        public DbSet<Apartment> Apartments { get; set; }
    }
}
