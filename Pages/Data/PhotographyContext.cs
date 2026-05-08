using Microsoft.EntityFrameworkCore;

public class PhotographyContext : DbContext
{
    public PhotographyContext(DbContextOptions<PhotographyContext> options) : base(options) { }

    public DbSet<Product> Products { get; set; }
    public DbSet<Category> Categories { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        
        modelBuilder.Entity<Category>().HasData(
            new Category { CategoryID = 1, Name = "Weddings", Description = "Capturing your 'I Do' moments forever." },
            new Category { CategoryID = 2, Name = "Graduation", Description = "Celebrate your hard-earned milestone." },
            new Category { CategoryID = 3, Name = "Portraits", Description = "Single person and family lifestyle sessions." },
            new Category { CategoryID = 4, Name = "Events", Description = "Proms, parties, and special gatherings." },
            new Category { CategoryID = 5, Name = "Newborn", Description = "Sweet, tiny memories for new parents." }
        );

        
        for (int i = 1; i <= 30; i++)
        {
            string title, desc, img;
            int catId;

          
            if (i <= 6) { 
                title = $"Elegant Wedding Vol {i}"; 
                desc = "Full day coverage with a romantic, airy edit.";
                img = "/images/wedding.jpg";
                catId = 1;
            }
            else if (i <= 12) { 
                title = $"Senior Glow Grad {i-6}"; 
                desc = "Celebrate your graduation with sunshine and smiles!";
                img = "/images/grad.jpg";
                catId = 2;
            }
            else if (i <= 18) { 
                title = $"Classic Portrait {i-12}"; 
                desc = "Perfect for LinkedIn, social media, or just because!";
                img = "/images/portrait.jpg";
                catId = 3;
            }
            else if (i <= 24) { 
                title = $"Prom Night Magic {i-18}"; 
                desc = "Capture the sparkle of your big night with friends.";
                img = "/images/prom.jpg";
                catId = 4;
            }
            else { 
                title = $"Tiny Toes Newborn {i-24}"; 
                desc = "Soft, cozy shots of your newest little love.";
                img = "/images/newborn.jpg";
                catId = 5;
            }

            modelBuilder.Entity<Product>().HasData(
                new Product
                {
                    ProductID = i,
                    Title = title,
                    Price = 150.00M + (i * 10), 
                    CategoryID = catId,
                    Description = desc,
                    ImageUrl = img 
                }
            );
        }
    }
}