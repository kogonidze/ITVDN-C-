namespace SalaryAndTaxes;

internal class SalaryCalculator
{
    public double CalculateSalary(JobPosition jobPosition, int experienceInYears)
    {
        var salary = 0.0;

        salary += CalculateSalaryByPosition(jobPosition);
        salary *= CalculateSalaryBonusByExperience(experienceInYears);

        return salary;
    }

    public double CalculateTaxes(double salary)
        => salary * CalculateTaxesCoefficient(salary);

    private double CalculateSalaryByPosition(JobPosition jobPosition)
        => jobPosition switch
        {
            JobPosition.Trainee => 0,
            JobPosition.Junior => 500,
            JobPosition.Middle => 1500,
            JobPosition.Senior => 3000,
            _ => 0
        };

    private double CalculateSalaryBonusByExperience(int experienceInYears)
        => experienceInYears switch
        {
            < 1 => 1,
            >= 1 and < 2 => 1.1,
            >= 2 and < 5 => 1.25,
            >= 5 and < 10 => 1.33,
            >= 10 => 1.5
        };

    private double CalculateTaxesCoefficient(double salary)
        => salary switch
        {
            < 1000 => 0.05,
            >= 1000 and < 2000 => 0.12,
            >= 2000 and < 5000 => 0.15,
            >= 5000 => 0.18,
            _ => 0
        };
}
