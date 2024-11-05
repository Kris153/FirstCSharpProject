using System;
using FirstProject.Backend.Dtos;
using FirstProject.Backend.Entities;

namespace FirstProject.Backend.Mapping;

public static class EmployeeMapping
{
    public static EmployeeEntity ToEntity(this AddEmployeeDto employeeDto)
    {
        EmployeeEntity employee = new()
            {
                Name = employeeDto.Name, MonthSalary = employeeDto.MonthSalary,
                YearInWhichHeWorkedId = employeeDto.YearInWhichHeWorkedId
            };
        return employee;
    }

    public static EmployeeSummaryDto ToEmployeeSummaryDto(this EmployeeEntity employeeEntity)
    {
        EmployeeSummaryDto employeeDto = new(
                employeeEntity.Id, employeeEntity.Name, employeeEntity.MonthSalary, employeeEntity.Year!.Year
            );
        return employeeDto;
    }

    public static EmployeeSalarySummaryDto ToEmployeeSalarySummaryDto(this EmployeeEntity employeeEntity, YearEntity year)
    {
        decimal moneyForIncomeTax;
        decimal moneyForInsuranceTax;
        if(Decimal.Compare(employeeEntity.MonthSalary, year.MinimumThreshold) < 0)
        {
            moneyForIncomeTax = 0;
            moneyForInsuranceTax = 0;
        }else
        {
            moneyForIncomeTax = Math.Round(Decimal.Multiply(employeeEntity.MonthSalary, Decimal.Divide(year.IncomeTaxPercentage, 100)), 2);
            if(Decimal.Compare(employeeEntity.MonthSalary, year.MaximumInsuranceThreshold) < 0)
            {
                moneyForInsuranceTax = Math.Round(Decimal.Multiply(employeeEntity.MonthSalary, Decimal.Divide(year.InsurancePercantage, 100)), 2);
            }else
            {
                moneyForInsuranceTax = Math.Round(Decimal.Multiply(year.MaximumInsuranceThreshold, Decimal.Divide(year.InsurancePercantage, 100)), 2);
            }
        }
        return new(employeeEntity.Name, employeeEntity.MonthSalary, employeeEntity.Year!.Year, moneyForIncomeTax, moneyForInsuranceTax, employeeEntity.MonthSalary-moneyForIncomeTax-moneyForInsuranceTax);
    }
}