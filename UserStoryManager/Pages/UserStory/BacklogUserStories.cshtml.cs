using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using UserStoryManager.Models;
using UserStoryManager.Services;

namespace UserStoryManager.Pages.UserStory
{
    public class BacklogUserStoriesModel : PageModel
    {
        private StoryBoardService storyBoardService;
        public StoryBoard StoryBoard { get; set; }

        public BacklogUserStoriesModel(StoryBoardService storyBoardService)
        {
            this.storyBoardService = storyBoardService;
        }

        public void OnGet()
        {
            StoryBoard = storyBoardService.GetStoryBoard();
        }

        public IActionResult OnPost(int id)
        {
            storyBoardService.ChangeState(id);
            return RedirectToPage("/UserStory/BacklogUserStories");
        }
    }

}