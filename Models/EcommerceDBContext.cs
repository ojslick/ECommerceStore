using Microsoft.EntityFrameworkCore;
using ECommerceStore.Models;

public class ECommerceDbContext : DbContext
{
    public ECommerceDbContext(DbContextOptions<ECommerceDbContext> options) : base(options) { }
    public DbSet<Product> Products { get; set; }
    public DbSet<Category> Categories { get; set; }
}