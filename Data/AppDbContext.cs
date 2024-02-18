using CommandQueryFramework.Models;
using Microsoft.EntityFrameworkCore;

namespace CommandQueryFramework.Data;

public sealed class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

    public DbSet<Product> Products { get; set; }
}