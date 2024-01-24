using InventoryManagemnet.API.Delivery.INfrastructure.Entities;
using Microsoft.EntityFrameworkCore;

namespace InventoryManagemnet.API.Delivery.INfrastructure.Configuration
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> dbContextOptions) : base(dbContextOptions)
        { }
        
        public DbSet<InventoryItem> InventoryItems { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            modelBuilder.Entity<InventoryItem>().HasData(
                new InventoryItem
                {
                    ProductId = Guid.NewGuid(), 
                    ProductName = "مثال محصول",
                    Quantity = 10
                });

        }
    }
}
