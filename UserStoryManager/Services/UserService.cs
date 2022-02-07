using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UserStoryManager.MockData;
using UserStoryManager.Models;

namespace UserStoryManager.Services
{
    public class UserService
    {
        public List<User> Users;

        public UserService()
        {
            Users = MockUsers.GetUsers();
        }

        public List<User> GetUsers()
        {
            return Users;
        }

        public User GetUser(string userName, string password)
        {
            foreach (var user in Users)
            {
                if (user.UserName.ToLower() == userName.ToLower() && user.Password == password) return user;
            }
            return null;
        }
    }
}
