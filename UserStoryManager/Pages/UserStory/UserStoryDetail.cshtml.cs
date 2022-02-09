using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using UserStoryManager.Services;

namespace UserStoryManager.Pages.UserStory
{
    public class UserStoryDetailModel : PageModel
    {
        [BindProperty] public Models.UserStory UserStory { get; set; }
        public List<Models.UserStory> UserStories { get; private set; }
        private UserStoryService _userStoryService;

        public UserStoryDetailModel(UserStoryService userStoryService)
        {
            this._userStoryService = userStoryService;
        }
        public void OnGet(int id)
        {
            UserStories = _userStoryService.GetUserStories();
            UserStory = _userStoryService.GetUserStory(id);
        }
    }
}