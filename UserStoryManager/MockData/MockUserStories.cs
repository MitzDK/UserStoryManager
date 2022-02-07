using System;
using System.Collections.Generic;
using UserStoryManager.Models;

namespace UserStoryManager.MockData
{
    public class MockUserStories
    {
        private static List<UserStory> userStories = new List<UserStory>()
        {
            new UserStory("Create Story", "As P.O I want to create a new Story So ...", 10, DateTime.Now, 5, "Medium"),
            new UserStory("Edit Story", "As P.O I want to edit a Story So ...", 7, DateTime.Now, 5, "Small"),
            new UserStory("Move Story", "As team member I want to move a Story So ...", 6, DateTime.Now, 5, "Large"),
            new UserStory("Delete Story", "As team member I want to delete a Story So ...", 4, DateTime.Now, 5, "Small")
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