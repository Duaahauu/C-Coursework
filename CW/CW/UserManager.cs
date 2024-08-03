using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CW
{
    public class UserManager
    {
        private List<User> users = new List<User>();

        public void AddUser(User user)
        {
            users.Add(user);
        }

        public List<User> GetAllUsers()
        {
            return users;
        }

        public List<User> GetUsersByRole(string role)
        {
            return users.FindAll(u => u.Role.Equals(role, StringComparison.OrdinalIgnoreCase));
        }

        public void EditUser(string name, User updatedUser)
        {
            for (int i = 0; i < users.Count; i++)
            {
                if (users[i].Name.Equals(name, StringComparison.OrdinalIgnoreCase))
                {
                    users[i] = updatedUser;
                    break;
                }
            }
        }

        public void DeleteUser(string name)
        {
            users.RemoveAll(u => u.Name.Equals(name, StringComparison.OrdinalIgnoreCase));
        }
    }
}
