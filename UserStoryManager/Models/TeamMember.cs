using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace UserStoryManager.Models
{
    public class TeamMember : User
    {
        public string Role { get; set; }
        public string ImageString { get; set; }

        public TeamMember()
        {
            
        }

        public TeamMember(int id, string name, string userName, string password, string role, string imageString) : base(id, name, userName, password)
        {
            Role = role;
            ImageString = imageString;
        }
    }
}
