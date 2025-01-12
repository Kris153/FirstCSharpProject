﻿// <auto-generated />
using System;
using FirstProject.Backend.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace FirstProject.Backend.Data.Migrations
{
    [DbContext(typeof(EmployeeSalaryAppContext))]
    partial class EmployeeSalaryAppContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "8.0.10");

            modelBuilder.Entity("FirstProject.Backend.Entities.EmployeeEntity", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<decimal>("MonthSalary")
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int>("YearInWhichHeWorkedId")
                        .HasColumnType("INTEGER");

                    b.Property<int?>("yearId")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("yearId");

                    b.ToTable("Employees");
                });

            modelBuilder.Entity("FirstProject.Backend.Entities.YearEntity", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<decimal>("IncomeTaxPercentage")
                        .HasColumnType("TEXT");

                    b.Property<decimal>("InsurancePercantage")
                        .HasColumnType("TEXT");

                    b.Property<decimal>("MaximumInsuranceThreshold")
                        .HasColumnType("TEXT");

                    b.Property<decimal>("MinimumThreshold")
                        .HasColumnType("TEXT");

                    b.Property<int>("Year")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.ToTable("Years");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            IncomeTaxPercentage = 10m,
                            InsurancePercantage = 15m,
                            MaximumInsuranceThreshold = 3000m,
                            MinimumThreshold = 1000m,
                            Year = 2024
                        },
                        new
                        {
                            Id = 2,
                            IncomeTaxPercentage = 10m,
                            InsurancePercantage = 10m,
                            MaximumInsuranceThreshold = 2500m,
                            MinimumThreshold = 1000m,
                            Year = 2023
                        },
                        new
                        {
                            Id = 3,
                            IncomeTaxPercentage = 10m,
                            InsurancePercantage = 15m,
                            MaximumInsuranceThreshold = 2000m,
                            MinimumThreshold = 800m,
                            Year = 2022
                        },
                        new
                        {
                            Id = 4,
                            IncomeTaxPercentage = 10m,
                            InsurancePercantage = 15m,
                            MaximumInsuranceThreshold = 3000m,
                            MinimumThreshold = 850m,
                            Year = 1999
                        },
                        new
                        {
                            Id = 5,
                            IncomeTaxPercentage = 8m,
                            InsurancePercantage = 11m,
                            MaximumInsuranceThreshold = 2300m,
                            MinimumThreshold = 750m,
                            Year = 1998
                        });
                });

            modelBuilder.Entity("FirstProject.Backend.Entities.EmployeeEntity", b =>
                {
                    b.HasOne("FirstProject.Backend.Entities.YearEntity", "year")
                        .WithMany()
                        .HasForeignKey("yearId");

                    b.Navigation("year");
                });
#pragma warning restore 612, 618
        }
    }
}
