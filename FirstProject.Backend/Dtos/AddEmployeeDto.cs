using System.ComponentModel.DataAnnotations;

namespace FirstProject.Backend.Dtos;

public record class AddEmployeeDto( 
    [Required(AllowEmptyStrings = false, ErrorMessage = "The name field is required")]
    string Name,

    [Required(ErrorMessage = "The month salary field is required")]
    [Range(1, (double)decimal.MaxValue, ErrorMessage = "The salary should be a positive number")]
    decimal MonthSalary, 

    [Required(ErrorMessage = "The year in which he worked field is required")]
    int YearInWhichHeWorkedId);

