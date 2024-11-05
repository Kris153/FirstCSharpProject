using System;
using FirstProject.Backend.Data;
using FirstProject.Backend.Dtos;
using FirstProject.Backend.Entities;
using FirstProject.Backend.Mapping;
using Microsoft.EntityFrameworkCore;

namespace FirstProject.Backend.Endpoints;

public static class EmployeeEndpoints
{
    const string GetEmployeeEndpointName = "GetEmployee";
    public static RouteGroupBuilder MapEmployeesEndpoints(this WebApplication app)
    {
        var group = app.MapGroup("employees");
        group.MapGet("/", (EmployeeSalaryAppContext dbContext) => 
            dbContext.Employees.Include(e => e.Year).Select(e => e.ToEmployeeSummaryDto()));


        group.MapGet("/{id}", (int id, EmployeeSalaryAppContext dbContext) => 
        {
            EmployeeEntity? employee = dbContext.Employees.Find(id);
            if(employee is null)
            {
                return Results.NotFound();
            }else
            {
                YearEntity year = dbContext.Years.Find(employee.YearInWhichHeWorkedId)!;
                EmployeeSalarySummaryDto toReturn = employee.ToEmployeeSalarySummaryDto(year);
                return Results.Ok(toReturn);
            }
        }).WithName(GetEmployeeEndpointName);
        
        group.MapPost("/", (AddEmployeeDto employeeToAdd, EmployeeSalaryAppContext dbContext) =>
        {
            EmployeeEntity employee = employeeToAdd.ToEntity();
            employee.Year = dbContext.Years.Find(employeeToAdd.YearInWhichHeWorkedId);
            dbContext.Employees.Add(employee);
            dbContext.SaveChanges();

            EmployeeSummaryDto employeeDto = employee.ToEmployeeSummaryDto();
            return Results.CreatedAtRoute(GetEmployeeEndpointName, new {id = employee.Id}, employeeDto);
        }).WithParameterValidation();

        return group;
    }
}
