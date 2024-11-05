using System;
using FirstProject.Backend.Dtos;
using FirstProject.Backend.Entities;

namespace FirstProject.Backend.Mapping;

public static class YearMapping
{
    public static YearSummaryDto ToYearSummaryDto(this YearEntity year)
    {
        YearSummaryDto yearDto = new(year.Id, year.Year, year.MinimumThreshold, year.IncomeTaxPercentage, year.InsurancePercantage, year.MaximumInsuranceThreshold);
        return yearDto;
    }
    public static YearEntity ToYearEntity(this AddYearDto yearDto)
    {
        return new()
        {
            Year = yearDto.Year,
            MinimumThreshold = yearDto.MinimumThreshold,
            IncomeTaxPercentage = yearDto.IncomeTaxPercentage,
            InsurancePercantage = yearDto.InsurancePercantage,
            MaximumInsuranceThreshold = yearDto.MaximumInsuranceThreshold
        };
    }
}
