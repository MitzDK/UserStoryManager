using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc.RazorPages;
using UserStoryManager.Models;
using UserStoryManager.Services;

namespace UserStoryManager.Pages
{
    public class UserStoriesModel : PageModel
    {
        private UserStoryService userStoryService;
        public List<UserStory> UserStories { get; private set; }

        public UserStoriesModel(UserStoryService userStoryService)
        {
            this.userStoryService = userStoryService;
        }
        public void OnGet()
        {
            UserStories = userStoryService.GetUserStories();
        }
    }
}