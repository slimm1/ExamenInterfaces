using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenInterfaces.model
{
    internal class UserList
    {
        public List<User> Users { get; set; }

        public UserList() {
            this.Users = new();
        }   
        public bool AddUser(User u)
        {
            if (!Users.Contains(u))
            {
                Users.Add(u);
                return true;
            }
            return false;
        }

        public bool RemoveProd(User u)
        {
            return Users.Remove(u);
        }

        public User? GetUserByData(string username, string password) {
            foreach (User u in Users) {
                if (u.username.Equals(username) && u.password.Equals(password)) {
                    return u;
                }
            }
            return null;
        }
    }
}
