using System;

namespace FirstProject.FrontEnd.Models;

public class EmployeeSalarySummary
{
public required string Name { get; set; }

public required decimal MonthSalary { get; set; }

public int YearInWhichHeWorked { get; set; }

public decimal MoneyForIncomeTax { get; set; }

public decimal MoneyForInsuranceTax { get; set; }
public decimal NetSalaryForMonth { get; set; }
}
