using CommandQueryFramework.Models;

namespace CommandQueryFramework.Data;

public static class DbInitializer
{
    public static void Initialize(AppDbContext context)
    {
        // Ensure the database is created
        context.Database.EnsureCreated();

        // Check if the DB already has data
        if (context.Products.Any())
        {
            return; // DB has been seeded
        }

        var products = new Product[]
        {
            new Product { Name = "Laptop", Price = 1200.00M },
            new Product { Name = "Smartphone", Price = 800.00M },
            new Product { Name = "Tablet", Price = 400.00M },
        };

        foreach (Product p in products)
        {
            context.Products.Add(p);
        }
        context.SaveChanges();
    }
}