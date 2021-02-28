using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace User
{
    class User
    {
        private int age;
        public string Username { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public int Age
        {
            get
            {
                return age;
            }
            set
            {
                if (value > 18)
                {
                    age = value;
                }
                else
                {
                    Console.WriteLine("Minors are not allowed to access the service! Registration stopped...");
                }
            }
        }
        public DateTime Date { get; set; }

        public User()
        {
            Date = DateTime.Now;
        }

        public static void PrintUserInfo(User user)
        {
            if (user != null)
            {
                FormattingConsoleOutput.ColorsConsoleOutput($"Username: {user.Username}", ConsoleColor.Blue);
                FormattingConsoleOutput.ColorsConsoleOutput($"Name: {user.Name}", ConsoleColor.Green);
                FormattingConsoleOutput.ColorsConsoleOutput($"Surname: {user.Surname}", ConsoleColor.Yellow);
                FormattingConsoleOutput.ColorsConsoleOutput($"Age: {user.Age}", ConsoleColor.Magenta);
                FormattingConsoleOutput.ColorsConsoleOutput($"Date&Time of the registration: {user.Date}", ConsoleColor.DarkCyan);
                FormattingConsoleOutput.ColorsConsoleOutput($"{new string('-', 50)}", ConsoleColor.Red);  
            }
        }

        public static void InputNewUserInfo(User user)
        {
            Console.WriteLine("Enter your username: ");
            user.Username = Console.ReadLine();
            Console.WriteLine("Enter your name: ");
            user.Name = Console.ReadLine();
            Console.WriteLine("Enter your surname: ");
            user.Surname = Console.ReadLine();
            Console.WriteLine("Enter your age: ");

            if (int.TryParse(Console.ReadLine(), out int age))
            {
                user.Age = age;
            }
            else
            {
                Console.WriteLine("Field age must be integer! Enter the correct value!");
            }
        }

        public static User CreateUser()
        {
            User newUser = new User();

            InputNewUserInfo(newUser);
            if (!CheckIfCreatedUserIsValid(newUser))
            {
                return null;
            }

            Console.WriteLine("User was created successfully!");

            return newUser;
        }

        public static bool CheckIfCreatedUserIsValid(User user)
        {
            if (user.Age == 0)
            {
                return false;
            }

            return true;
        }
    }
}
