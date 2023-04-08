using SalaryAndTaxes;

var employee = new Employee("Alexey", "Sidorov");
employee.JobPosition = JobPosition.Senior;
employee.ExperienceInYears = 15;

Console.WriteLine(employee.ShowInfo());

Console.ReadKey();