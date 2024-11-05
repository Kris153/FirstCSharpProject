using System;

namespace FirstProject.Backend.Entities;

public class EmployeeEntity
{
public int Id { get; set; }
public required string Name { get; set; }

public required decimal MonthSalary { get; set; }

public int YearInWhichHeWorkedId { get; set; }

public YearEntity? Year { get; set; }
}
