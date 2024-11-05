using System;

namespace FirstProject.FrontEnd.Models;

public class YearSummary
{
public int Id { get; set; }
public int Year { get; set; }
public decimal MinimumThreshold { get; set; }
public decimal IncomeTaxPercentage { get; set; }
public decimal InsurancePercantage { get; set; }
public decimal MaximumInsuranceThreshold { get; set; }
}
