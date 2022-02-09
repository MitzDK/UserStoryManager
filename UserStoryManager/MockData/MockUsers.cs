using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UserStoryManager.Models;

namespace UserStoryManager.MockData
{
    public class MockUsers
    {
        private static List<TeamMember> users = new List<TeamMember>()
        {
            new TeamMember(1, "Victor Jejlskov", "Victor", "123", "Agent 007", "victor.png"),
            new TeamMember(2, "Simon Boysen", "Simon", "123", "CEO Developer", "simom.png"),
            new TeamMember(3, "Martin Lylloff", "Martin", "123", "Lead Designer", "martin.png"),
            new TeamMember(4, "Frederik Bressendorff", "Frederik", "123", "Paint Artist", "frederik.png"),
            new TeamMember(5, "Andreas Broberg", "Andreas", "123", "Døllerdreng", "andreas.png"),
        };

        public static List<TeamMember> GetUsers()
        {
            return users;
        }
    }
}
