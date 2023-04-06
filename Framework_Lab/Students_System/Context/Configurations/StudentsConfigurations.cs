using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Students_System.Entities;

namespace Students_System.Context.Configurations
{
    public class StudentsConfigurations : IEntityTypeConfiguration<Students>
    {
        public void Configure(EntityTypeBuilder<Students> builder)
        {
            // Foreign key to Homeworks: one-to-many
            builder
                .HasMany(left => left.Homeworks)
                .WithOne(right => right.Students)
                .HasForeignKey(result => result.Students_ID)
                .IsRequired();
        }
    }
}
