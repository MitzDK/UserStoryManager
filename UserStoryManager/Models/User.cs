using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace UserStoryManager.Models
{
    public class User
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }

        public User()
        {
            
        }
        public User(int id, string name, string userName, string password)
        {
            Id = id;
            Name = name;
            UserName = userName;
            Password = password;
        }
    }
}
