using Labs_EF.Entities;
using Labs_EF.Generator;
using Microsoft.EntityFrameworkCore;

namespace Labs_EF.DataContext
{
    public class HospitalContext : DbContext
    {
        public HospitalContext(DbContextOptions<HospitalContext> options) : base (options) { }

        public virtual DbSet<Diagnoses> Diagnoses { get; set; }

        public virtual DbSet<Medicaments> Medicaments { get; set; }
        
        public virtual DbSet<Patients> Patients { get; set; }
        
        public virtual DbSet<Visitations> Visitations { get; set; }

        public virtual DbSet<Doctors> Doctors { get; set; }

        public virtual DbSet<Prescription> Prescriptions { get; set; }

        #region Set the base configuration for the classes
        // Method for set base configureation for all models in database
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Get the all fields from Base Entity and set the default value for them 
            foreach (var entity in modelBuilder.Model.GetEntityTypes()
                .Where(result => typeof(Entity).IsAssignableFrom(result.ClrType)))
            {
                modelBuilder.Entity(entity.Name).Property(nameof(Entity.ID))
                    .IsRequired().HasDefaultValueSql("NEWID()");

                modelBuilder.Entity(entity.Name).Property(nameof(Entity.Created_at))
                    .IsRequired().HasDefaultValueSql("GetDate()");

                modelBuilder.Entity(entity.Name).Property(nameof(Entity.Updated_at))
                    .IsRequired().HasDefaultValueSql("GetDate()");
            }

            #region Generate all data using Bogus Library
            /*DataGenerator.Generate_all_Data();
              modelBuilder.Entity<Patients>().HasData(DataGenerator.Patients);
              modelBuilder.Entity<Doctors>().HasData(DataGenerator.Doctors);
              modelBuilder.Entity<Visitations>().HasData(DataGenerator.Visitations);
              modelBuilder.Entity<Diagnoses>().HasData(DataGenerator.Diagnoses);
              modelBuilder.Entity<Medicaments>().HasData(DataGenerator.Medicaments);
              modelBuilder.Entity<Prescription>().HasData(DataGenerator.Prescriptions);*/
            #endregion
        }
        #endregion
    }
}
