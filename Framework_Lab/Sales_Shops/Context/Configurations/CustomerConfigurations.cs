using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Sales_Shops.Entities;

namespace Sales_Shops.Context.Configurations
{
    public class CustomerConfigurations : IEntityTypeConfiguration<Customers>
    {
        public void Configure(EntityTypeBuilder<Customers> builder)
        {
            builder
                .HasMany(left => left.Sales)
                .WithOne(right => right.Customers)
                .HasForeignKey(result => result.Customer_ID)
                .IsRequired();
        }
    }
}
