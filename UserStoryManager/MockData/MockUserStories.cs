using System;
using System.Collections.Generic;
using UserStoryManager.Models;

namespace UserStoryManager.MockData
{
    public class MockUserStories
    {
        private static StoryBoard _storyBoard;
        private static List<TeamMember> _users;

        public static void StartUp()
        {
            _users = MockUsers.GetUsers();
        }
        private static List<UserStory> userStories = new List<UserStory>()
        {
            new UserStory("Create Story", "The abillity to create new stories", 0, 5, (TeamMember)MockUsers.GetUsers()[1], (TeamMember)MockUsers.GetUsers()[1], DateTime.Today, "")
        };

        public static List<UserStory> GetUserStories()
        {
            userStories[1].State = 1;
            userStories[2].State = 2;
            userStories[3].State = 3;
            return userStories;
        }
    }
}