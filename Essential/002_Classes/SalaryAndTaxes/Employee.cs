namespace SalaryAndTaxes;

internal class Employee
{
    private string firstName;
    private string lastName;
    private SalaryCalculator calculator;

    public Employee(string firstName, string lastName)
    {
        this.firstName = firstName;
        this.lastName = lastName;
        calculator = new SalaryCalculator();
    }

    public string FirstName => firstName;

    public string LastName => lastName;

    public int ExperienceInYears { get; set; }

    public JobPosition JobPosition { get; set; }

    public double Salary => calculator.CalculateSalary(JobPosition, ExperienceInYears);

    public double Taxes => calculator.CalculateTaxes(Salary);

    public string ShowInfo()
        => $"FirstName: {FirstName}. LastName: {LastName}. " +
        $"JobPosition: {JobPosition}. ExperienceInYears: {ExperienceInYears}. " +
        $"Salary: {Salary}. Taxes: {Taxes}";
}
