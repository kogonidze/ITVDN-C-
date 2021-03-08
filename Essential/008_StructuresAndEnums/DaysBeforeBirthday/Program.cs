using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DaysBeforeBirthday
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your birthday date in format mm-dd-yyyy: ");
            var birthdayDate = DateTime.Parse(Console.ReadLine());
            var today = DateTime.Now;
            DateTime yourNextBirthday;

            if (birthdayDate.DayOfYear >= today.DayOfYear)
            {
                yourNextBirthday = new DateTime(DateTime.Now.Year, birthdayDate.Month, birthdayDate.Day);
            }
            else
            {
                yourNextBirthday = new DateTime(DateTime.Now.Year+1, birthdayDate.Month, birthdayDate.Day);
            }

            var leftDaysForNextBirthday = yourNextBirthday - today;

            Console.WriteLine($"Your next birthday in {leftDaysForNextBirthday.Days} days!");

            Console.ReadKey();
        }
    }
}
