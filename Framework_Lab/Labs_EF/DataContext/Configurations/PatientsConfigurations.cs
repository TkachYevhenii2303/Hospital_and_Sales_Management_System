using Labs_EF.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Labs_EF.DataContext.Configurations
{
    public class PatientsConfigurations : IEntityTypeConfiguration<Patients>
    {
        public void Configure(EntityTypeBuilder<Patients> builder)
        {
            builder
                .HasMany(left => left.Visitations)
                .WithOne(right => right.Patients)
                .HasForeignKey(result => result.Patients_ID)
                .IsRequired();

            builder
                .HasMany(left => left.Diagnoses)
                .WithOne(right => right.Patients)
                .HasForeignKey(result => result.Patiens_ID)
                .IsRequired();
        }
    }
}
