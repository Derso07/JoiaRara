using JoiaRara.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace JoiaRara.Infrastructure.Context;

public class DataContext : DbContext
{
    public DbSet<Batch> Batches{get;set;}
    public DbSet<Jewel> Jewels{get;set;}
    public DbSet<Sale> Sales { get;set; }
    public DbSet<User> Users { get; set; }
    public DbSet<UserRole> UserRoles { get;set;}
    public DbSet<ItemBatch> ItemBatches { get; set; }
    public DbSet<ItemSale> ItemSales { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        => optionsBuilder.UseSqlServer("ConnectionString");
}