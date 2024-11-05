using System;


namespace FirstProject.FrontEnd.Models;

public class EmployeeSummary
{
public int Id { get; set; }
public required string Name { get; set; }

public required decimal MonthSalary { get; set; }

public int YearInWhichHeWorked { get; set; }
}
