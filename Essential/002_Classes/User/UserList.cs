using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace User
{
    class UserList
    {
        public List<User> Users;

        public UserList()
        {
            Users = new List<User>();
        }

        public void DisplayListOfUsers()
        {
            Console.WriteLine("List of users: ");

            if (!CheckIfListOfUsersIsEmpty())
            {
                foreach (var user in Users)
                {
                    User.PrintUserInfo(user);
                }
            }
        }

        private bool CheckIfListOfUsersIsEmpty()
        {
            if (Users.Count == 0)
            {
                Console.WriteLine("There are no users of service yet!");
                return true;
            }

            return false;
        }
    }
}
