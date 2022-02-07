using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using UserStoryManager.Services;

namespace UserStoryManager.Pages.UserStory
{
    public class UserStoriesModel : PageModel
    {
        private UserStoryService userStoryService;
        public List<Models.UserStory> UserStories { get; private set; }

        public UserStoriesModel(UserStoryService userStoryService)
        {
            this.userStoryService = userStoryService;
        }

        public void OnGet()
        {
            UserStories = userStoryService.GetUserStories();
        }

        public IActionResult OnPost(int id)
        {
            UserStories = userStoryService.GetUserStories();
            userStoryService.ChangeState(id);
            return Page();
        }

        public IActionResult OnPostReset(int id)
        {
            UserStories = userStoryService.GetUserStories();
            userStoryService.ResetState(id);
            return Page();
        }
    }
    
}