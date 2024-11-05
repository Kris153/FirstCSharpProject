using System;
using FirstProject.Backend.Entities;
using Microsoft.EntityFrameworkCore;

namespace FirstProject.Backend.Data;

public class EmployeeSalaryAppContext(DbContextOptions<EmployeeSalaryAppContext> options) : DbContext(options)
{
    public DbSet<EmployeeEntity> Employees => Set<EmployeeEntity>();
    public DbSet<YearEntity> Years => Set<YearEntity>();

    // protected override void OnModelCreating(ModelBuilder modelBuilder)
    // {
    //     modelBuilder.Entity<YearEntity>().HasData(
    //         new{
    //             Id = 1,
    //             Year = 2024,
    //             MinimumThreshold = 1000M,
    //             IncomeTaxPercentage = 10M,
    //             InsurancePercantage = 15M,
    //             MaximumInsuranceThreshold = 3000M},
    //         new{
    //             Id = 2,
    //             Year = 2023,
    //             MinimumThreshold = 1000M,
    //             IncomeTaxPercentage = 10M,
    //             InsurancePercantage = 10M,
    //             MaximumInsuranceThreshold = 2500M},
    //         new{
    //             Id = 3,
    //             Year = 2022,
    //             MinimumThreshold = 800M,
    //             IncomeTaxPercentage = 10M,
    //             InsurancePercantage = 15M,
    //          MaximumInsuranceThreshold = 2000M},
    //         new{
    //             Id = 4,
    //             Year = 1999,
    //             MinimumThreshold = 850M,
    //             IncomeTaxPercentage = 10M,
    //             InsurancePercantage = 15M,
    //             MaximumInsuranceThreshold = 3000M},
    //         new{
    //             Id = 5,
    //             Year = 1998,
    //             MinimumThreshold = 750M,
    //             IncomeTaxPercentage = 8M,
    //             InsurancePercantage = 11M,
    //             MaximumInsuranceThreshold = 2300M}
    //     );
    // }
}
