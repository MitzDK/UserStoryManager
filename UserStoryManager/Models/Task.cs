using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace UserStoryManager.Models
{
    public class Task : BacklogItem
    {
        public UserStory UserStory { get; set; }

        public Task()
        {
            
        }

        public Task(string title, string description, int state, int priority, TeamMember developer, TeamMember creator, DateTime dateCreated, Sprint sprint, string note, int estimatedHours, int usedHours, DateTime dateTimeStarted, UserStory userStory) : base(title, description, state, priority, developer, creator, dateCreated, sprint, note, estimatedHours, usedHours, dateTimeStarted)
        {
            UserStory = userStory;
        }

        public override string GetId()
        {
            if (UserStory != null)
                return UserStory.GetId() + "T" + Id;
            return "T" + Id;
        }
    }
}
