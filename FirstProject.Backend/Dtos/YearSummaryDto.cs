namespace FirstProject.Backend.Dtos;

public record class YearSummaryDto(int Id, int Year, decimal MinimumThreshold, decimal IncomeTaxPercentage, decimal InsurancePercantage, decimal MaximumInsuranceThreshold);
