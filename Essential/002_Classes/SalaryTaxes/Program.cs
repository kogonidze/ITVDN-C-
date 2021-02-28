using Shared;
using System;

namespace SalaryTaxes
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee JohnAdams = new Employee("Adams", "J.");
            JohnAdams.Position = Position.Junior;
            JohnAdams.WorkExperience = 1;

            JohnAdams.PrintInfo();

            Employee AndreyIvanov = new Employee("Ivanov", "A.");
            AndreyIvanov.Position = Position.Senior;
            AndreyIvanov.WorkExperience = 6;

            AndreyIvanov.PrintInfo();

            Console.ReadKey();
        }
    }
}
