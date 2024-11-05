namespace FirstProject.Backend.Dtos;

public record class EmployeeSummaryDto(
    int Id,  
    string Name, 
    decimal MonthSalary, 
    int YearInWhichHeWorked);
