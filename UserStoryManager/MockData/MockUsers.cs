using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UserStoryManager.Models;

namespace UserStoryManager.MockData
{
    public class MockUsers
    {
        private static List<User> users = new List<User>()
        {
            new User("Victor", "123"),
            new User("Simon", "123"),
            new User("Martin", "123"),
            new User("Frederik", "123"),
            new User("Andreas", "123"),

        };

        public static List<User> GetUsers()
        {
            return users;
        }
    }
}
