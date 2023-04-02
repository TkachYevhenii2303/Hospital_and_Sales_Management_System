using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Sales_Shops.Entities;

namespace Sales_Shops.Context.Configurations
{
    public class ProductsConfigurations : IEntityTypeConfiguration<Products>
    {
        public void Configure(EntityTypeBuilder<Products> builder)
        {
            builder
                .HasMany(left => left.Sales)
                .WithOne(right => right.Products)
                .HasForeignKey(result => result.Products_ID)
                .IsRequired();
        }
    }
}
