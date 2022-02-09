using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using UserStoryManager.Models;
using UserStoryManager.Services;

namespace UserStoryManager.Pages.UserStory
{
    public class UserStoryDetailModel : PageModel
    {
        [BindProperty] public Models.Card CardStory { get; set; }
        public StoryBoard StoryBoard { get; set; }
        private StoryBoardService _storyBoardService;

        public UserStoryDetailModel(StoryBoardService storyBoardService)
        {
            this._storyBoardService = storyBoardService;
        }
        public void OnGet(int id)
        {
            StoryBoard = _storyBoardService.GetStoryBoard();
            CardStory = _storyBoardService.GetUserStory(id);
        }
    }
}