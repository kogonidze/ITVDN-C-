using Shared;
using System;

namespace SalaryTaxes
{
    enum Position
    {
        Junior,
        Middle,
        Senior
    }
    class Employee
    {
        public string Surname { get; set; }
        public string Name { get; set; }
        public Position Position { get; set; }
        public int WorkExperience { get; set; }

        public Employee(string surname, string name)
        {
            Surname = surname;
            Name = name;
        }

        public double CalculateSalary(Employee employee)
        {
            var result = 0.0;
            var position = employee.Position;
            var workExperience = employee.WorkExperience;

            result += CalculateBaseSalaryByPosition(position);
            result *= CalculateCoefficientExperienceBonus(workExperience);

            return result;
        }

        public double CalculateTaxes(Employee employee)
        {
            return CalculateSalary(employee) * 0.13;
        }

        private double CalculateBaseSalaryByPosition(Position position)
        {
            switch (position)
            {
                case Position.Junior:
                    return 500;
                case Position.Middle:
                    return 1200;
                case Position.Senior:
                    return 2000;
                default:
                    break;
            }

            return default(double);
        }

        private double CalculateCoefficientExperienceBonus(int workExperience)
        {
            if (workExperience <= 1)
            {
                return 1;
            }
            else if (workExperience > 1 && workExperience <= 3)
            {
                return 1.1;
            }
            else if (workExperience > 3 && workExperience <= 5)
            {
                return 1.5;
            }
            else if (workExperience > 5)
            {
                return 2;
            }

            return default(double);
        }

        public void PrintInfo()
        {
            FormattingConsoleOutput.ColorsConsoleOutput($"Name: {Name}", ConsoleColor.Blue);
            FormattingConsoleOutput.ColorsConsoleOutput($"Surname: {Surname}", ConsoleColor.Yellow);
            FormattingConsoleOutput.ColorsConsoleOutput($"Position: {Position}", ConsoleColor.Cyan);
            FormattingConsoleOutput.ColorsConsoleOutput($"Work experience: {WorkExperience}", ConsoleColor.Gray);
            FormattingConsoleOutput.ColorsConsoleOutput($"Salary: {CalculateSalary(this)}", ConsoleColor.Green);
            FormattingConsoleOutput.ColorsConsoleOutput($"Taxes: {CalculateTaxes(this)}", ConsoleColor.Red);
            FormattingConsoleOutput.ColorsConsoleOutput($"{new string('-', 50)}", ConsoleColor.White);

        }
    }
}
