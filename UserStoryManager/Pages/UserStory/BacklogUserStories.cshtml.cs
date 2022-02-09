using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using UserStoryManager.Services;

namespace UserStoryManager.Pages.UserStory
{
    public class BacklogUserStoriesModel : PageModel
    {
        private UserStoryService userStoryService;
        public List<Models.UserStory> UserStories { get; private set; }

        public BacklogUserStoriesModel(UserStoryService userStoryService)
        {
            this.userStoryService = userStoryService;
        }

        public void OnGet()
        {
            UserStories = userStoryService.GetUserStories();
        }

        public IActionResult OnPost(int id)
        {
            userStoryService.ChangeState(id);
            return RedirectToPage("/UserStory/BacklogUserStories");
        }
    }

}