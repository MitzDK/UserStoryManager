using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace UserStoryManager.Models
{
    public class Card
    {
        private static int nextId = 1;
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public int State { get; set; }
        public int Priority { get; set; }
        public TeamMember Developer { get; set; }
        public TeamMember Creator { get; set; }
        public DateTime DateCreated { get; set; }
        public Sprint Sprint { get; set; }
        public string Note { get; set; }

        public Card()
        {
            
        }

        public Card(string title, string description, int state, int priority, TeamMember developer, TeamMember creator, DateTime dateCreated, Sprint sprint, string note)
        {
            Id = nextId++;
            Title = title;
            Description = description;
            State = state;
            Priority = priority;
            Developer = developer;
            Creator = creator;
            DateCreated = dateCreated;
            Sprint = sprint;
            Note = note;
        }

        public virtual string GetId()
        {
            return "C" + Id;
        }
    }
}
