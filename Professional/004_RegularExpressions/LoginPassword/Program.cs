using LoginPassword.Constants;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;

namespace LoginPassword
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine(MessagesConstants.EnterLoginMsg);
                var login = Console.ReadLine();

                if (!FieldValidation(login, PatternConstants.patternForLogin))
                {
                    Console.WriteLine(MessagesConstants.IncorrectSymbolsErrorMsg);
                    break;
                }

                Console.WriteLine(MessagesConstants.EnterPasswordMsg);
                var passwd = Console.ReadLine();

                if (!FieldValidation(passwd, PatternConstants.patternForPassword))
                {
                    Console.WriteLine(MessagesConstants.IncorrectSymbolsErrorMsg);
                    break;
                }

                Console.WriteLine(MessagesConstants.SuccessfullRegistrationMsg);
                Thread.Sleep(3000);

                Console.Clear();
            }

            Console.ReadKey();
        }

        static bool FieldValidation(string input, string pattern)
        {
            if (Regex.IsMatch(input, pattern))
            {
                return true;
            }

            return false;
        }
    }
}
