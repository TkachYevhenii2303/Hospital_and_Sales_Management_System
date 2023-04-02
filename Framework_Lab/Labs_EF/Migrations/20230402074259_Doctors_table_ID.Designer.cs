﻿// <auto-generated />
using System;
using Labs_EF.DataContext;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Labs_EF.Migrations
{
    [DbContext(typeof(HospitalContext))]
    [Migration("20230402074259_Doctors_table_ID")]
    partial class Doctors_table_ID
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.4")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Labs_EF.Entities.Diagnoses", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier")
                        .HasDefaultValueSql("NewID()");

                    b.Property<string>("Comments")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("Created_at")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime2")
                        .HasDefaultValueSql("GetDate()");

                    b.Property<string>("Diagnoses_title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("PatientsId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("Updated_at")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime2")
                        .HasDefaultValueSql("GetDate()");

                    b.HasKey("Id");

                    b.HasIndex("PatientsId");

                    b.ToTable("Diagnoses");
                });

            modelBuilder.Entity("Labs_EF.Entities.Doctors", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier")
                        .HasDefaultValueSql("NewID()");

                    b.Property<DateTime>("Created_at")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime2")
                        .HasDefaultValueSql("GetDate()");

                    b.Property<string>("Doctors_name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Specialty")
                        .HasColumnType("int");

                    b.Property<DateTime>("Updated_at")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime2")
                        .HasDefaultValueSql("GetDate()");

                    b.HasKey("Id");

                    b.ToTable("Doctors");
                });

            modelBuilder.Entity("Labs_EF.Entities.Medicaments", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier")
                        .HasDefaultValueSql("NewID()");

                    b.Property<DateTime>("Created_at")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime2")
                        .HasDefaultValueSql("GetDate()");

                    b.Property<string>("Medicaments_title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("Updated_at")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime2")
                        .HasDefaultValueSql("GetDate()");

                    b.HasKey("Id");

                    b.ToTable("Medicaments");
                });

            modelBuilder.Entity("Labs_EF.Entities.Patients", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier")
                        .HasDefaultValueSql("NewID()");

                    b.Property<string>("Address")
                        .IsRequired()
                        .IsUnicode(true)
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("Created_at")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime2")
                        .HasDefaultValueSql("GetDate()");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("Has_Insuranse")
                        .HasColumnType("bit");

                    b.Property<string>("Patients_first_name")
                        .IsRequired()
                        .IsUnicode(true)
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Patients_last_name")
                        .IsRequired()
                        .IsUnicode(true)
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("Updated_at")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime2")
                        .HasDefaultValueSql("GetDate()");

                    b.HasKey("Id");

                    b.ToTable("Patients");
                });

            modelBuilder.Entity("Labs_EF.Entities.Visitations", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier")
                        .HasDefaultValueSql("NewID()");

                    b.Property<string>("Comments")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("Created_at")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime2")
                        .HasDefaultValueSql("GetDate()");

                    b.Property<DateTime>("Date")
                        .HasColumnType("datetime2");

                    b.Property<Guid>("DoctorsId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("PatientsId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("Updated_at")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime2")
                        .HasDefaultValueSql("GetDate()");

                    b.HasKey("Id");

                    b.HasIndex("DoctorsId");

                    b.HasIndex("PatientsId");

                    b.ToTable("Visitations");
                });

            modelBuilder.Entity("MedicamentsPatients", b =>
                {
                    b.Property<Guid>("MedicamentsId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("PatientsId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("MedicamentsId", "PatientsId");

                    b.HasIndex("PatientsId");

                    b.ToTable("Prescriptions", (string)null);
                });

            modelBuilder.Entity("Labs_EF.Entities.Diagnoses", b =>
                {
                    b.HasOne("Labs_EF.Entities.Patients", "Patients")
                        .WithMany("Diagnoses")
                        .HasForeignKey("PatientsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Patients");
                });

            modelBuilder.Entity("Labs_EF.Entities.Visitations", b =>
                {
                    b.HasOne("Labs_EF.Entities.Doctors", "Doctors")
                        .WithMany("Visitations")
                        .HasForeignKey("DoctorsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Labs_EF.Entities.Patients", "Patients")
                        .WithMany("Visitations")
                        .HasForeignKey("PatientsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Doctors");

                    b.Navigation("Patients");
                });

            modelBuilder.Entity("MedicamentsPatients", b =>
                {
                    b.HasOne("Labs_EF.Entities.Medicaments", null)
                        .WithMany()
                        .HasForeignKey("MedicamentsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Labs_EF.Entities.Patients", null)
                        .WithMany()
                        .HasForeignKey("PatientsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Labs_EF.Entities.Doctors", b =>
                {
                    b.Navigation("Visitations");
                });

            modelBuilder.Entity("Labs_EF.Entities.Patients", b =>
                {
                    b.Navigation("Diagnoses");

                    b.Navigation("Visitations");
                });
#pragma warning restore 612, 618
        }
    }
}
