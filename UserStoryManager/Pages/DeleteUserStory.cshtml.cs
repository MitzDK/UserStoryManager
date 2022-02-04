using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using UserStoryManager.Models;
using UserStoryManager.Services;

namespace UserStoryManager.Pages
{
    public class DeleteUserStoryModel : PageModel
    {
        [BindProperty] public UserStory UserStory { get; set; }
        private UserStoryService userStoryService;

        public DeleteUserStoryModel(UserStoryService userStoryService)
        {
            this.userStoryService = userStoryService;
        }
        public void OnGet(int id)
        {
            UserStory = userStoryService.GetUserStory(id);
        }

        public IActionResult OnPost()
        {
            UserStory deletedUserStory = userStoryService.DeleteUserStory(UserStory.Id);
            return RedirectToPage("UserStories");
        }
    }
}