using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
