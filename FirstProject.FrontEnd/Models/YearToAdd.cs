using System;
using System.ComponentModel.DataAnnotations;

namespace FirstProject.FrontEnd.Models;

public class YearToAdd
{

[Required(ErrorMessage = "The year field is required")]
[Range(1, (double)decimal.MaxValue, ErrorMessage = "The year should be a positive number")]
public int? Year { get; set; }

[Required(ErrorMessage = "The minimum threshold field is required")]
[Range(1, (double)decimal.MaxValue, ErrorMessage = "The minimum threshold should be a positive number")]
public decimal? MinimumThreshold { get; set; }

[Required(ErrorMessage = "The income tax percantage field is required")]
[Range(1, (double)decimal.MaxValue, ErrorMessage = "The income tax percantage should be a positive number")]
public decimal? IncomeTaxPercentage { get; set; }

[Required(ErrorMessage = "The insurance percantage field is required")]
[Range(1, (double)decimal.MaxValue, ErrorMessage = "The insurance percantage should be a positive number")]
public decimal? InsurancePercantage { get; set; }

[Required(ErrorMessage = "The maximum insurance threshold field is required")]
[Range(1, (double)decimal.MaxValue, ErrorMessage = "The maximum insurance threshold should be a positive number")]
public decimal? MaximumInsuranceThreshold { get; set; }
}