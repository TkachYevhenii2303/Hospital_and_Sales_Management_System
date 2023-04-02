using Microsoft.EntityFrameworkCore;
using Sales_Shops.Context.Configurations;
using Sales_Shops.Entities;
using Sales_Shops.Generator;
using System.Reflection;

namespace Sales_Shops.Context
{
    public class SalesContext : DbContext
    {
        public SalesContext(DbContextOptions<SalesContext> options) : base(options) { }

        public DbSet<Customers> Customers { get; set; } 

        public DbSet<Sales> Sales { get; set; }

        public DbSet<Products> Products { get; set; }

        public DbSet<Stores> Stores { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            foreach (var entity in modelBuilder.Model.GetEntityTypes()
                .Where(e => typeof(Entity).IsAssignableFrom(e.ClrType)))
            {
                modelBuilder.Entity(entity.Name).Property(nameof(Entity.Id))
                    .IsRequired().HasDefaultValueSql("NEWID()");

                modelBuilder.Entity(entity.Name).Property(nameof(Entity.Created_at))
                    .IsRequired().HasDefaultValueSql("GETDATE()");

                modelBuilder.Entity(entity.Name).Property(nameof(Entity.Updated_at))
                    .IsRequired().HasDefaultValueSql("GETDATE()");
            }

            modelBuilder.ApplyConfiguration(new CustomerConfigurations());
            modelBuilder.ApplyConfiguration(new ProductsConfigurations());
            modelBuilder.ApplyConfiguration(new StoresConfigurations());

            DataGenerator.Generate_all_Data();
            modelBuilder.Entity<Customers>().HasData(DataGenerator.Customers);
            modelBuilder.Entity<Products>().HasData(DataGenerator.Products);
            modelBuilder.Entity<Stores>().HasData(DataGenerator.Stores);
            modelBuilder.Entity<Sales>().HasData(DataGenerator.Sales);
        }
    }
}
