using Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Invoice
{
    enum Article
    {
        Laptop,
        Iphone,
        Passat,
        Earphones
    }
    class Invoice
    {
        public string Account { get; }
        public string Customer { get; }
        public string Provider { get; set; }

        public Invoice(string account, string customer, string provider)
        {
            Account = account;
            Customer = customer;
            Provider = provider;
        }

        public Article Article { get; set; }
        public int Quantity { get; set; }

        public double GetOrderCost(bool includeNDS)
        {
            var result = 0.0;

            result += GetBaseCost();

            if (!includeNDS)
            {
                return result *= Quantity;
            }

            result *= Quantity;

            return result += result * 0.13;
        }

        private double GetBaseCost()
        {
            switch (Article)
            {
                case Article.Laptop:
                    return 1000;
                case Article.Iphone:
                    return 700;
                case Article.Passat:
                    return 10000;
                case Article.Earphones:
                    return 50;
                default:
                    return default(double);
            }
        }

        public void PrintInfo()
        {
            FormattingConsoleOutput.ColorsConsoleOutput($"Account: {Account}", ConsoleColor.Blue);
            FormattingConsoleOutput.ColorsConsoleOutput($"Customer: {Customer}", ConsoleColor.Yellow);
            FormattingConsoleOutput.ColorsConsoleOutput($"Provider: {Provider}", ConsoleColor.Cyan);
            FormattingConsoleOutput.ColorsConsoleOutput($"Article: {Article}", ConsoleColor.Gray);
            FormattingConsoleOutput.ColorsConsoleOutput($"Quantity: {Quantity}", ConsoleColor.DarkMagenta);
            FormattingConsoleOutput.ColorsConsoleOutput($"Price without NDS: {GetOrderCost(false)}", ConsoleColor.Green);
            FormattingConsoleOutput.ColorsConsoleOutput($"Price with NDS: {GetOrderCost(true)}", ConsoleColor.Red);
            FormattingConsoleOutput.ColorsConsoleOutput($"{new string('-', 50)}", ConsoleColor.White);

        }
    }
}
