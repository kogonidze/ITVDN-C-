using System;
using Shared;

namespace User
{
    class Program
    {
        static void Main(string[] args)
        {
            UserList userList = new UserList();
            Menu.StartWork(Constants.MenuText,
                () => userList.Users.Add(User.CreateUser()),
                () => userList.DisplayListOfUsers(),
                () => Environment.Exit(0));
        }
    }
}
