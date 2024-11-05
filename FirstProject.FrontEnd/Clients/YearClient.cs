using System;
using FirstProject.FrontEnd.Models;

namespace FirstProject.FrontEnd.Clients;

public class YearClient(HttpClient httpClient)
{
// private readonly List<YearSummary> years = 
//     [
//         new()
//         {
//             Id = 1,
//             Year = 2024,
//             MinimumThreshold = 1000,
//             IncomeTaxPercentage = 10,
//             InsurancePercantage = 15,
//             MaximumInsuranceThreshold = 3000
//         },
//         new()
//         {
//             Id = 2,
//             Year = 2023,
//             MinimumThreshold = 1000,
//             IncomeTaxPercentage = 10,
//             InsurancePercantage = 10,
//             MaximumInsuranceThreshold = 2500
//         },
//         new()
//         {
//             Id = 3,
//             Year = 2022,
//             MinimumThreshold = 800,
//             IncomeTaxPercentage = 10,
//             InsurancePercantage = 15,
//             MaximumInsuranceThreshold = 2000
//         },
//         new()
//         {
//             Id = 4,
//             Year = 1999,
//             MinimumThreshold = 850,
//             IncomeTaxPercentage = 10,
//             InsurancePercantage = 15,
//             MaximumInsuranceThreshold = 3000
//         },
//         new()
//         {
//             Id = 5,
//             Year = 1998,
//             MinimumThreshold = 750,
//             IncomeTaxPercentage = 8,
//             InsurancePercantage = 11,
//             MaximumInsuranceThreshold = 2300
//         },
//     ];
    public async Task<YearSummary[]> GetYearSummariesAsync() 
    =>  await httpClient.GetFromJsonAsync<YearSummary[]>("/years") ?? [];

    public async Task AddYearAsync(YearToAdd year)
    => await httpClient.PostAsJsonAsync("/years", year);
    public async Task<YearSummary?> GetYearSummaryByYearAsync(int Year)
    => await httpClient.GetFromJsonAsync<YearSummary>($"/years/{Year}");
}
