using Labs_EF.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Labs_EF.DataContext.Configurations
{
    public class DoctorsConfigurations : IEntityTypeConfiguration<Doctors>
    {
        public void Configure(EntityTypeBuilder<Doctors> builder)
        {
            builder
                .HasMany(left => left.Visitations)
                .WithOne(right => right.Doctors)
                .HasForeignKey(result => result.Doctors_ID)
                .IsRequired();
        }
    }
}
