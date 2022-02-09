using System;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using UserStoryManager.Services;

namespace UserStoryManager.Pages.UserStory
{
    public class DeleteUserStoryModel : PageModel
    {
        [BindProperty] public Models.Card Card { get; set; }
        private StoryBoardService storyBoardService;
        

        public DeleteUserStoryModel(StoryBoardService userStoryService)
        {
            this.storyBoardService = userStoryService;
        }
        public void OnGet(int id)
        {
            Card = storyBoardService.GetUserStory(id);
        }

        public IActionResult OnPost()
        {
            Models.Card deletedUserStory = storyBoardService.DeleteUserStory(Card.Id);
            return RedirectToPage("/UserStory/UserStories");
        }
    }
}