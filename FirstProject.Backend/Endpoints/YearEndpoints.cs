using System;
using FirstProject.Backend.Data;
using FirstProject.Backend.Dtos;
using FirstProject.Backend.Entities;
using FirstProject.Backend.Mapping;

namespace FirstProject.Backend.Endpoints;

public static class YearEndpoints
{
    const string GetYearEndpointName = "GetYear";
    public static RouteGroupBuilder MapYearsEndpoints(this WebApplication app)
    {
        var group = app.MapGroup("years");

        group.MapGet("/", (EmployeeSalaryAppContext dbContext) => 
            dbContext.Years.Select(e => e.ToYearSummaryDto()));

        group.MapGet("/{year}", (int year, EmployeeSalaryAppContext dbContext) => 
        {
            dbContext.Years.First(y => y.Year == year);
            YearEntity? yearEntity = dbContext.Years.First(y => y.Year == year);
            if(yearEntity is null)
            {
                return Results.NotFound();
            }else
            {
                YearSummaryDto toReturn = yearEntity.ToYearSummaryDto();
                return Results.Ok(toReturn);
            }
        }).WithName(GetYearEndpointName);
        
        group.MapPost("/", (AddYearDto yearToAdd, EmployeeSalaryAppContext dbContext) =>
        {
            YearEntity year = yearToAdd.ToYearEntity();

            dbContext.Years.Add(year);
            dbContext.SaveChanges();

            YearSummaryDto yearDto = year.ToYearSummaryDto();
            return Results.CreatedAtRoute(GetYearEndpointName, new {id = year.Id}, yearDto);
        }).WithParameterValidation();

        return group;
    }
}
