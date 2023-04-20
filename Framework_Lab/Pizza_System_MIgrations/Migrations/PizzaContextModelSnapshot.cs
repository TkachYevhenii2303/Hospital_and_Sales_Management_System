﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Pizza_System_BLL.Context;

#nullable disable

namespace Pizza_System_MIgrations.Migrations
{
    [DbContext(typeof(PizzaContext))]
    partial class PizzaContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("PizzaToppings", b =>
                {
                    b.Property<Guid>("PizzasID")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("ToppingsID")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("PizzasID", "ToppingsID");

                    b.HasIndex("ToppingsID");

                    b.ToTable("PizzaToppings");
                });

            modelBuilder.Entity("Pizza_System_BLL.Entities.Pizza", b =>
                {
                    b.Property<Guid>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier")
                        .HasDefaultValueSql("NEWID()");

                    b.Property<string>("Pizza_title")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<Guid>("SauceID")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("ID");

                    b.HasIndex("SauceID");

                    b.ToTable("Pizza_table");
                });

            modelBuilder.Entity("Pizza_System_BLL.Entities.Sauce", b =>
                {
                    b.Property<Guid>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier")
                        .HasDefaultValueSql("NEWID()");

                    b.Property<bool>("Is_vegan")
                        .HasColumnType("bit");

                    b.Property<string>("Sauce_title")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.HasKey("ID");

                    b.ToTable("Sauce_table");
                });

            modelBuilder.Entity("Pizza_System_BLL.Entities.Toppings", b =>
                {
                    b.Property<Guid>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier")
                        .HasDefaultValueSql("NEWID()");

                    b.Property<decimal>("Calories")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("Toppings_table")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.HasKey("ID");

                    b.ToTable("Topping_table");
                });

            modelBuilder.Entity("PizzaToppings", b =>
                {
                    b.HasOne("Pizza_System_BLL.Entities.Pizza", null)
                        .WithMany()
                        .HasForeignKey("PizzasID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Pizza_System_BLL.Entities.Toppings", null)
                        .WithMany()
                        .HasForeignKey("ToppingsID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Pizza_System_BLL.Entities.Pizza", b =>
                {
                    b.HasOne("Pizza_System_BLL.Entities.Sauce", "Sauce")
                        .WithMany()
                        .HasForeignKey("SauceID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Sauce");
                });
#pragma warning restore 612, 618
        }
    }
}
