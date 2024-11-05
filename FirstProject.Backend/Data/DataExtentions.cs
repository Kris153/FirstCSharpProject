using System;
using Microsoft.EntityFrameworkCore;

namespace FirstProject.Backend.Data;

public static class DataExtentions
{
    public static void MigrateDb(this WebApplication app)
    {
        using var scope = app.Services.CreateScope();
        var dbContext = scope.ServiceProvider.GetRequiredService<EmployeeSalaryAppContext>();
        dbContext.Database.Migrate();
    }
}
