using PropertyPortfolio.Models;
using Microsoft.EntityFrameworkCore;

namespace PropertyPortfolio.Database
{
    public class PropertyPortfolioDbContext : DbContext
    {
        public PropertyPortfolioDbContext(DbContextOptions<PropertyPortfolioDbContext> options) : base(options)
        {
        }

        public DbSet<Owner> Owners { get; set; }
        public DbSet<Property> Properties { get; set; }
    }
}