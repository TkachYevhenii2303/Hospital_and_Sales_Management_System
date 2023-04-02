using Labs_EF.DataContext.Configurations;
using Labs_EF.Entities;
using Labs_EF.Generator;
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

        public DbSet<Prescription> Prescriptions { get; set; }

        // Method for set base configureation for all models in database
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Get the all fields from Base Entity and set the default value for them 
            foreach (var entity in modelBuilder.Model.GetEntityTypes()
                .Where(result => typeof(Entity).IsAssignableFrom(result.ClrType)))
            {
                modelBuilder.Entity(entity.Name).Property(nameof(Entity.Id))
                    .IsRequired().HasDefaultValueSql("NEWID()");

                modelBuilder.Entity(entity.Name).Property(nameof(Entity.Created_at))
                    .IsRequired().HasDefaultValueSql("GetDate()");

                modelBuilder.Entity(entity.Name).Property(nameof(Entity.Updated_at))
                    .IsRequired().HasDefaultValueSql("GetDate()");
            }

            modelBuilder.ApplyConfiguration(new DoctorsConfigurations());
            modelBuilder.ApplyConfiguration(new PatientsConfigurations());
            modelBuilder.ApplyConfiguration(new PrescriptionConfigurations());

            // Generate Fake Data using Bogus
          /*  DataGenerator.Generate_all_Data();
            modelBuilder.Entity<Patients>().HasData(DataGenerator.Patients);
            modelBuilder.Entity<Doctors>().HasData(DataGenerator.Doctors);
            modelBuilder.Entity<Visitations>().HasData(DataGenerator.Visitations);
            modelBuilder.Entity<Diagnoses>().HasData(DataGenerator.Diagnoses);
            modelBuilder.Entity<Medicaments>().HasData(DataGenerator.Medicaments);
            modelBuilder.Entity<Prescription>().HasData(DataGenerator.Prescriptions);*/
        }
    }
}
