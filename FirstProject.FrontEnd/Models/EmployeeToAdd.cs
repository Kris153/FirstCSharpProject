using System;
using System.ComponentModel.DataAnnotations;

namespace FirstProject.FrontEnd.Models;

public class EmployeeToAdd
{

[Required(AllowEmptyStrings = false, ErrorMessage = "The name field is required")]
public required string Name { get; set; }

[Required(ErrorMessage = "The month salary field is required")]
[Range(1, (double)decimal.MaxValue, ErrorMessage = "The salary should be a positive number")]
public required decimal? MonthSalary { get; set; }

[Required(ErrorMessage = "The year in which he worked field is required")]
public int YearInWhichHeWorkedId { get; set; }
}
