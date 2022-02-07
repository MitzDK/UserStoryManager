using System.Collections.Generic;
using UserStoryManager.MockData;
using UserStoryManager.Models;

namespace UserStoryManager.Services
{
    public class UserStoryService
    {
        private List<UserStory> userStories;

        public UserStoryService()
        {
            userStories = MockUserStories.GetUserStories();
        }

        public List<UserStory> GetUserStories()
        {
            return userStories;
        }

        public UserStory GetUserStory(int id)
        {
            foreach (UserStory userStory in userStories)
            {
                if (userStory.Id == id) return userStory;
            }
            return null;
        }

        public UserStory DeleteUserStory(int userStoryId)
        {
            UserStory userStoryToBeDeleted = null;
            foreach (UserStory userStory in userStories)
            {
                if (userStory.Id == userStoryId)
                {
                    userStoryToBeDeleted = userStory;
                    break;
                }
            }

            if (userStoryToBeDeleted != null)
            {
                userStories.Remove(userStoryToBeDeleted);
            }

            return userStoryToBeDeleted;
        }

        public void ChangeState(int userStoryId)
        {
            GetUserStory(userStoryId).State++;
        }

        public void ResetState(int userStoryId)
        {
            GetUserStory(userStoryId).State = 0;
        }
    }
}