using System;
using FirstProject.FrontEnd.Components.Pages;
using FirstProject.FrontEnd.Models;

namespace FirstProject.FrontEnd.Clients;

public class EmployeeClient(HttpClient httpClient)
{

    private readonly Task<YearSummary[]> yearsTasks = new YearClient(httpClient).GetYearSummariesAsync();

    public async Task<EmployeeSummary[]?> GetEmployeesAsync() 
    => await httpClient.GetFromJsonAsync<EmployeeSummary[]>("/employees") ?? [];
    public async Task AddEmployeeAsync(EmployeeToAdd employee)
    => await httpClient.PostAsJsonAsync("/employees", employee);
    public async Task<EmployeeSalarySummary> GetEmployeeSalarySummaryByIdAsync(int Id)
    => await httpClient.GetFromJsonAsync<EmployeeSalarySummary>($"/employees/{Id}") ?? new(){Name = "Null", MonthSalary = 0, MoneyForIncomeTax = 0, MoneyForInsuranceTax = 0, NetSalaryForMonth = 0, YearInWhichHeWorked = 0};
}