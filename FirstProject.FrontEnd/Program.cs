using FirstProject.FrontEnd.Clients;
using FirstProject.FrontEnd.Components;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorComponents().AddInteractiveServerComponents();

var employeeSalaryAppApiUrl = builder.Configuration["EmployeeSalaryAppApiUrl"];

builder.Services.AddHttpClient<EmployeeClient>(
    client => client.BaseAddress = new Uri(employeeSalaryAppApiUrl!));
    builder.Services.AddHttpClient<YearClient>(
    client => client.BaseAddress = new Uri(employeeSalaryAppApiUrl!));

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error", createScopeForErrors: true);
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

// app.UseHttpsRedirection();

app.UseStaticFiles();
app.UseAntiforgery();

app.MapRazorComponents<App>().AddInteractiveServerRenderMode();

app.Run();
