namespace FirstProject.Backend.Dtos;

public record class AddYearDto(int Year, decimal MinimumThreshold, decimal IncomeTaxPercentage, decimal InsurancePercantage, decimal MaximumInsuranceThreshold);
