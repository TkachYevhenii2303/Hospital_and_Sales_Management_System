using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using Microsoft.IdentityModel.Protocols;
using Sales_Management_DAL.Bogus_Generator;
using Sales_Management_DAL.Context.Configurations;
using Sales_Management_DAL.Entities;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sales_Management_DAL.Context.Base_Context
{
    public class SalesContext : DbContext
    {
        private readonly ILoggerFactory logger;

        public virtual DbSet<Customers> Customers { get; set; }

        public virtual DbSet<Products> Products { get; set; }

        public virtual DbSet<Stores> Stores { get; set; }   

        public virtual DbSet<Sales> Sales { get; set; }

        public SalesContext(DbContextOptions<SalesContext> options, ILoggerFactory logger) : base(options)
        {
            this.logger = logger;
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseLoggerFactory(logger);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            foreach (var entity in modelBuilder.Model.GetEntityTypes()
                .Where(result => typeof(Entity).IsAssignableFrom(result.ClrType)))
            {
                modelBuilder.Entity(entity.Name).Property(nameof(Entity.ID))
                    .IsRequired().HasDefaultValueSql("NEWID()");

                modelBuilder.Entity(entity.Name).Property(nameof(Entity.Created_at))
                   .IsRequired().HasDefaultValueSql("GETDATE()");

                modelBuilder.Entity(entity.Name).Property(nameof(Entity.Updated_at))
                    .IsRequired().HasDefaultValueSql("GETDATE()");
            }

            modelBuilder.ApplyConfiguration(new CustomerConfigurations());
            modelBuilder.ApplyConfiguration(new ProductsConfigurations());
            modelBuilder.ApplyConfiguration(new StoresConfigurations());
            modelBuilder.ApplyConfiguration(new SalesConfigurations());

            BogusGenerator.Generate_all_Data();
            modelBuilder.Entity<Customers>().HasData(BogusGenerator.Customers);
            modelBuilder.Entity<Products>().HasData(BogusGenerator.Products);
            modelBuilder.Entity<Stores>().HasData(BogusGenerator.Stores);
            modelBuilder.Entity<Sales>().HasData(BogusGenerator.Sales);
        }
    }
}
