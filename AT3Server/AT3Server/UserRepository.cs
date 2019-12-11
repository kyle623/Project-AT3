using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading.Tasks;

namespace AT3Server
{
    class UserRepository
    {
        List<User> users = new List<User>();
        // Function to add the user to in memory
        public void AddUser(User user)
        {
            users.Add(user);
        }
        // Function to retrieve the user based on user id
        public User GetUser(string userid)
        {
            try
            {
                return users.Single(u => u.UserId == userid);
            }
            catch
            {
                return users.First();
            }
        }
    }
}
