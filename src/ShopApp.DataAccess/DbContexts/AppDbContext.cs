using Microsoft.EntityFrameworkCore;
using ShopApp.Domain.Entities;

namespace ShopApp.DataAccess.DbContexts;

public class AppDbContext : DbContext
{

    public DbSet<Category> Categories { get; set; } = default!;

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        string connectionString = "Host = localhost; Port = 5432; Database = shop-db; User Id = postgres; Password = 0809";
        optionsBuilder.UseNpgsql(connectionString);
    }
}
