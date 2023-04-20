using Microsoft.EntityFrameworkCore;
using Pizza_System_BLL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pizza_System_BLL.Context
{
    public class PizzaContext : DbContext 
    {
        public PizzaContext(DbContextOptions<PizzaContext> options) : base( options ) { }

        public virtual DbSet<Pizza> Pizza { get; set; }

        public virtual DbSet<Sauce> Sauces { get; set; }

        public virtual DbSet<Toppings> Toppings { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            foreach (var entity in modelBuilder.Model.GetEntityTypes()
                .Where(result => typeof(Entity).IsAssignableFrom(result.ClrType)))
            {
                modelBuilder.Entity(entity.Name).Property(nameof(Entity.ID))
                    .IsRequired().HasDefaultValueSql("NEWID()");
            }
        }
    }
}
