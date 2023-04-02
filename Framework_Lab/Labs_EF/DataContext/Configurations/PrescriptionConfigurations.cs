using Labs_EF.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Labs_EF.DataContext.Configurations
{
    public class PrescriptionConfigurations : IEntityTypeConfiguration<Prescription>
    {
        public void Configure(EntityTypeBuilder<Prescription> builder)
        {
            builder
                .HasOne(left => left.Patients)
                .WithMany(right => right.Prescriptions)
                .HasForeignKey(result => result.Patients_ID)
                .IsRequired();

            builder
                .HasOne(left => left.Medicaments)
                .WithMany(right => right.Prescriptions)
                .HasForeignKey(result => result.Medicaments_ID)
                .IsRequired();
        }
    }
}
