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
    public class StoresConfigurations : IEntityTypeConfiguration<Stores>
    {
        public void Configure(EntityTypeBuilder<Stores> builder)
        {
            builder
                .HasMany(stores => stores.Sales)
                .WithOne(sales => sales.Stores)
                .HasForeignKey(sales => sales.Stores_ID)
                .HasConstraintName("FK_Stores_to_Sales");
        }
    }
}
