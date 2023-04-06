using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Students_System.Entities;

namespace Students_System.Context.Configurations
{
    public class StudentsCoursesConfigurations : IEntityTypeConfiguration<Students_Courses>
    {
        public void Configure(EntityTypeBuilder<Students_Courses> builder)
        {
            builder
                .HasOne(left => left.Students)
                .WithMany(right => right.Students_Courses)
                .HasForeignKey(result => result.Students_ID)
                .IsRequired();

            builder
                .HasOne(left => left.Courses)
                .WithMany(right => right.Students_Courses)
                .HasForeignKey(result => result.Courses_ID)
                .IsRequired();
        }
    }
}
