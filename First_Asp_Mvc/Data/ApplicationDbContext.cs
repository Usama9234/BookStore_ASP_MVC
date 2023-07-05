using First_Asp_Mvc.Models;
using Microsoft.EntityFrameworkCore;

namespace First_Asp_Mvc.Data
{
    public class ApplicationDbContext : DbContext 
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options):base(options)
        {
                
        }
        public DbSet<Category> Categories { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Category>().HasData(
                new Category { Id=1,Name="Acion",DisplayOrder=1},
                new Category { Id = 2, Name = "Drama", DisplayOrder = 2 },
                new Category { Id = 3, Name = "Science Fiction", DisplayOrder = 3 }
                );
        }
    }
    
}
