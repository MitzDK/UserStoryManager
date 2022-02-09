using System;
using System.Collections.Generic;
using UserStoryManager.Models;

namespace UserStoryManager.MockData
{
    public class MockUserStories
    {
        private static StoryBoard _storyBoard;
        private static List<TeamMember> _users;

        public static void StartUp()
        {
            _storyBoard = new StoryBoard();
            Sprint sprint = new Sprint(1,10,"SprintIcon1.PNG");
            _users = MockUsers.GetUsers();
            _storyBoard.AddCard(new UserStory("Create Story", "The abillity to create new stories", 0, 6, (TeamMember)MockUsers.GetUsers()[1], (TeamMember)MockUsers.GetUsers()[1], DateTime.Today, sprint, "Alle good 1", 10, 3, DateTime.Now, "As P.O I want to create a new Story So it can be handled in the project", "The new Card is created and added to the board", 4, "Large"));
            _storyBoard.AddCard(new UserStory("Update Story", "The ability to update a story", 0, 5, (TeamMember)MockUsers.GetUsers()[1], (TeamMember)MockUsers.GetUsers()[1], DateTime.Today, sprint, "All good 2", 12, 8, DateTime.Now, "As P.O or team member I want to edit a Story So it can be updated e.g. if the runner/driver (the team member that is implementing the story) is replaced", "The update of the Card is visible on the board", 5, "Large"));
            _storyBoard.AddCard(new UserStory("Move Story", "ability to move a story from one state to the next", 0, 4, (TeamMember)MockUsers.GetUsers()[1], (TeamMember)MockUsers.GetUsers()[1], DateTime.Today, sprint, "All good 3", 6, 2, DateTime.Now, "As team member I want to move a Story from one state to the next, so it will be visible that the story have changed state", "The user can move a story from one state to the next state. After the change of state the story is removed from the current collum in the board and inserted in the next collum. It must be possible to move back a story!", 3, "Medium"));
            _storyBoard.AddCard(new UserStory("Delete Story", "The ability to remove a story from the Board", 0, 3, (TeamMember)MockUsers.GetUsers()[1], (TeamMember)MockUsers.GetUsers()[1], DateTime.Today, sprint, "All good 4", 3, 1, DateTime.Now, "As a team member I want to delete a cancelled or out of date Story/task/fix from the Story Bord So the story is no longer visible", "The user can select and remove a Userstory from the board, the user must be asked for confirmation before the the story is deleted and have the posibility to regret ....", 2, "Small"));
        }

        public static StoryBoard GetStoryBoard()
        {
            StartUp();
            _storyBoard.Cards[1].State = 1;
            _storyBoard.Cards[2].State = 2;
            _storyBoard.Cards[3].State = 3;
            return _storyBoard;
        }
    }
}