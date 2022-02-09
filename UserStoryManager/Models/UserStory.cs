using System;
namespace UserStoryManager.Models
{
    public class UserStory : BacklogItem
    {
        public string Story { get; set; }
        public string AcceptanceCriteria { get; set; }
        public int BusinessValue { get; set; }
        public string StoryPoints { get; set; }

        public UserStory()
        {
            
        }

        public UserStory(string title, string description, int state, int priority, TeamMember developer, TeamMember creator, DateTime dateCreated, Sprint sprint, string note, int estimatedHours, int usedHours, DateTime dateTimeStarted, string story, string acceptanceCriteria, int businessValue, string storyPoints) : base(title, description, state, priority, developer, creator, dateCreated, sprint, note, estimatedHours, usedHours, dateTimeStarted)
        {
            Story = story;
            AcceptanceCriteria = acceptanceCriteria;
            BusinessValue = businessValue;
            StoryPoints = storyPoints;
        }

        public override string GetId()
        {
            return "U" + Id;
        }
    }
}