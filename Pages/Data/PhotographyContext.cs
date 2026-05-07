using Microsoft.EntityFrameworkCore;

public class PhotographyContext : DbContext
{
    public PhotographyContext(DbContextOptions<PhotographyContext> options) : base(options) { }

    public DbSet<Product> Products { get; set; }
    public DbSet<Category> Categories { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        // Seed Category
        modelBuilder.Entity<Category>().HasData(
            new Category { CategoryID = 1, Name = "Weddings", Description = "Forever starts here." }
        );

        // Seed 25+ Products for Paging
        for (int i = 1; i <= 30; i++)
        {
            modelBuilder.Entity<Product>().HasData(
                new Product { 
                    ProductID = i, 
                    Title = $"Package {i}", 
                    Price = 100 + i, 
                    CategoryID = 1, 
                    Description = "High quality shots." 
                }
            );
        }
    }
}