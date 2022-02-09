using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using UserStoryManager.Services;

namespace UserStoryManager.Pages.UserStory
{
    public class UserStoriesModel : PageModel
    {
        private UserStoryService _userStoryService;
        public List<Models.UserStory> UserStories { get; private set; }

        public UserStoriesModel(UserStoryService userStoryService)
        {
            this._userStoryService = userStoryService;
        }

        public void OnGet()
        {
            UserStories = _userStoryService.GetUserStories();
        }

        public IActionResult OnPost(int id)
        {
            UserStories = _userStoryService.GetUserStories();
            _userStoryService.ChangeState(id);
            return Page();
        }

        public IActionResult OnPostReset(int id)
        {
            UserStories = _userStoryService.GetUserStories();
            _userStoryService.ResetState(id);
            return Page();
        }
    }
    
}