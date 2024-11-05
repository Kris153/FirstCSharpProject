using FirstProject.Backend.Data;
using FirstProject.Backend.Endpoints;

var builder = WebApplication.CreateBuilder(args);

var connString = builder.Configuration.GetConnectionString("EmployeeSalaryApp");

builder.Services.AddSqlite<EmployeeSalaryAppContext>(connString);
builder.Services.AddScoped<EmployeeSalaryAppContext>();

var app = builder.Build();

app.MapEmployeesEndpoints();
app.MapYearsEndpoints();

app.MigrateDb();

app.Run();