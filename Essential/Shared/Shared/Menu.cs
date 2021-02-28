using System;

namespace Shared
{
    public abstract class Menu
    {
        public static void StartWork(string menuText, params Action[] actions)
        {
            while (true)
            {
                DisplayMenu(menuText);
                HandleSelectedMenuItem(actions);
            }
        }

        private static void DisplayMenu(string menuText)
        {
            Console.WriteLine(menuText);
        }

        private static void HandleSelectedMenuItem(Action[] actions)
        {
            if (int.TryParse(Console.ReadLine(), out int selectedItem) && selectedItem <= actions.Length)
            {
                Console.Clear();
                actions[selectedItem-1]();
                WaitForUserAnswer();
            }
            else
            {
                Console.WriteLine("You input incorrect menu item value!");
                Console.Clear();
            }
        }

        private static void WaitForUserAnswer()
        {
            Console.WriteLine("Enter any key to continue...");
            Console.ReadKey();
            Console.Clear();
        }
    }
}
