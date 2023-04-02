using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Sales_Shops.Entities;

namespace Sales_Shops.Context.Configurations
{
    public class StoresConfigurations : IEntityTypeConfiguration<Stores>
    {
        public void Configure(EntityTypeBuilder<Stores> builder)
        {
            builder
                .HasMany(left => left.Sales)
                .WithOne(right => right.Stores)
                .HasForeignKey(result => result.Stores_ID)
                .IsRequired();
        }
    }
}
