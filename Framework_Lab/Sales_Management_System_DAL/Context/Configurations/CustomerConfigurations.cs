using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Sales_Management_DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sales_Management_DAL.Context.Configurations
{
    public class CustomerConfigurations : IEntityTypeConfiguration<Customers>
    {
        public void Configure(EntityTypeBuilder<Customers> builder)
        {
            builder
                .HasMany(customers => customers.Sales)
                .WithOne(sales => sales.Customers)
                .HasForeignKey(result => result.Customers_ID)
                .HasConstraintName("FK_Customers_to_Sales");
        }
    }
}
