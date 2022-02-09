using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace UserStoryManager.Models
{
    public class BacklogItem : Card
    {
        public int EstimatedHours { get; set; }
        public int UsedHours { get; set; }
        public DateTime DateTimeStarted { get; set; }

        public BacklogItem()
        {
            
        }

        public BacklogItem(string title, string description, int state, int priority, TeamMember developer, TeamMember creator, DateTime dateCreated, Sprint sprint, string note, int estimatedHours, int usedHours, DateTime dateTimeStarted) : base(title, description, state, priority, developer, creator, dateCreated, sprint, note)
        {
            EstimatedHours = estimatedHours;
            UsedHours = usedHours;
            DateTimeStarted = dateTimeStarted;
        }
    }
}
