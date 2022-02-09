using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using UserStoryManager.Models;
using UserStoryManager.Services;

namespace UserStoryManager.Pages.UserStory
{
    public class UserStoriesModel : PageModel
    {
        private StoryBoardService _storyBoardService;
        public StoryBoard StoryBoard { get; set; }
        

        public UserStoriesModel(StoryBoardService storyBoardService)
        {
            this._storyBoardService = storyBoardService;
        }

        public void OnGet()
        {
            StoryBoard = _storyBoardService.GetStoryBoard();
        }

        public IActionResult OnPost(int id)
        {
            StoryBoard = _storyBoardService.GetStoryBoard();
            _storyBoardService.ChangeState(id);
            return Page();
        }

        public IActionResult OnPostReset(int id)
        {
            StoryBoard = _storyBoardService.GetStoryBoard();
            _storyBoardService.ResetState(id);
            return Page();
        }
    }
    
}