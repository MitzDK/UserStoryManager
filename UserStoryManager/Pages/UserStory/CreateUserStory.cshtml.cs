using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using UserStoryManager.Models;
using UserStoryManager.Services;

namespace UserStoryManager.Pages.UserStory
{
    public class CreateUserStoryModel : PageModel
    {
        private StoryBoardService _storyBoardService;
        [BindProperty] public Models.UserStory UserStory { get; set; }
        public StoryBoard StoryBoard { get; set; }

        public CreateUserStoryModel(StoryBoardService storyBoardService)
        {
            _storyBoardService = storyBoardService;
        }
        public void OnGet()
        {
            StoryBoard = _storyBoardService.GetStoryBoard();
        }
    }
}
