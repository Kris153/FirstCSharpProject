using System;

namespace FirstProject.Backend.Dtos;

public record class EmployeeSalarySummaryDto(
    string Name,
    decimal MonthSalary,
    int YearInWhichHeWorked,
    decimal MoneyForIncomeTax,
    decimal MoneyForInsuranceTax,
    decimal NetSalaryForMonth
);

