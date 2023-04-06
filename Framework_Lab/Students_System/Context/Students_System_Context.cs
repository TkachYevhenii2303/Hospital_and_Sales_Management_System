using Microsoft.EntityFrameworkCore;
using Students_System.Bogus_Generator;
using Students_System.Context.Configurations;
using Students_System.Entities;

namespace Students_System.Context
{
    // Creating the context for the Students_System_Context using DBContex 
    public class Students_System_Context : DbContext
    {
        public Students_System_Context(DbContextOptions<Students_System_Context> options) : base(options) { }

        public DbSet<Students> Students { get; set; }   

        // Using this method for set the base configurations for Entity and other entities
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // I set the default values sql for all fields in Base Entity, using Reflections
            foreach (var entity in modelBuilder.Model.GetEntityTypes()
                .Where(result => typeof(Entity).IsAssignableFrom(result.ClrType)))
            {
                modelBuilder.Entity(entity.Name).Property(nameof(Entity.Id))
                    .IsRequired().HasDefaultValueSql("NEWID()");

                modelBuilder.Entity(entity.Name).Property(nameof(Entity.Created_at))
                    .IsRequired().HasDefaultValueSql("GETDATE()");

                modelBuilder.Entity(entity.Name).Property(nameof(Entity.Updated_at))
                    .IsRequired().HasDefaultValueSql("GETDATE()");
            }

            modelBuilder.ApplyConfiguration(new StudentsConfigurations());

            // The base configuration for the next models
            Generator.Generate_all_Data();
            //modelBuilder.Entity<Students>().HasData(Generator.Students);


        }
    }
}
