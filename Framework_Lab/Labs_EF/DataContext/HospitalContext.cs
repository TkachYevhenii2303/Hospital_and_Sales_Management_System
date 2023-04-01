using Labs_EF.Entities;
using Microsoft.EntityFrameworkCore;

namespace Labs_EF.DataContext
{
    public class HospitalContext : DbContext
    {
        public HospitalContext(DbContextOptions<HospitalContext> options) : base (options) { }

        public DbSet<Diagnoses> Diagnoses { get; set; }

        public DbSet<Medicaments> Medicaments { get; set; }
        
        public DbSet<Patients> Patients { get; set; }
        
        public DbSet<Visitations> Visitations { get; set; }

        public DbSet<Doctors> Doctors { get; set; }

        // Method for set base configureation for all models in database
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Get the all fields from Base Entity and set the default value for them 
            foreach (var entity in modelBuilder.Model.GetEntityTypes()
                .Where(result => typeof(Entity).IsAssignableFrom(result.ClrType)))
            {
                modelBuilder.Entity(entity.Name).Property(nameof(Entity.Id))
                    .IsRequired().HasDefaultValueSql("NewID()");

                modelBuilder.Entity(entity.Name).Property(nameof(Entity.Created_at))
                    .IsRequired().HasDefaultValueSql("GetDate()");

                modelBuilder.Entity(entity.Name).Property(nameof(Entity.Updated_at))
                    .IsRequired().HasDefaultValueSql("GetDate()");
            }

            // Rename the Join Table title
            modelBuilder.Entity<Patients>()
                .HasMany(entity => entity.Medicaments)
                .WithMany(entity => entity.Patients)
                .UsingEntity(result => result.ToTable("Prescriptions"));
        }
    }
}
