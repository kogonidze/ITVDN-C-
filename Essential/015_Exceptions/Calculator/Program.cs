using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Enter the first value: ");
                var first = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter the second value: ");
                var second = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Enter the operation (+,-,*,/): ");
                var operation = Console.ReadLine();
                var result = 0.0;

                switch (operation)
                {
                    case "+":
                        result = Calculator.Add(first, second);
                        break;
                    case "-":
                        result = Calculator.Subtraction(first, second);
                        break;
                    case "*":
                        result = Calculator.Multiplication(first, second);
                        break;
                    case "/":
                        result = Calculator.Division(first, second);
                        break;
                    default:
                        Console.WriteLine("You entered incorrect value!");
                        break;
                }

                Console.WriteLine($"Result: {result}");
            }
            catch (FormatException)
            {
                Console.WriteLine("The operand must be numeric!");
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("Division by zero exception!");
            }
            catch(Exception ex)
            {
                Console.WriteLine($"Message: {ex.Message}");
                Console.WriteLine($"Inner exception: {ex.InnerException}");
            }

            Console.ReadKey();
        }
    }
}
