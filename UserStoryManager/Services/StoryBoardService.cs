using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UserStoryManager.MockData;
using UserStoryManager.Models;

namespace UserStoryManager.Services
{
    public class StoryBoardService
    {
        private StoryBoard _storyBoard;

        public StoryBoardService()
        {
            _storyBoard = MockUserStories.GetStoryBoard();
        }

        public StoryBoard GetStoryBoard()
        {
            return _storyBoard;
        }

        public Card GetUserStory(int id)
        {
            foreach (Card card in _storyBoard.Cards)
            {
                if (card.Id == id)
                {
                    return card;
                }
            }
            return null;
        }

        public void AddCard(Card card)
        {
            _storyBoard.AddCard(card);
        }

        public Card DeleteUserStory(int cardId)
        {
            Card cardTobeDeleted = null;
            foreach (Card card in _storyBoard.Cards)
            {
                if (card.Id == cardId)
                {
                    cardTobeDeleted = card;
                    break;
                }
            }

            if (cardTobeDeleted != null)
            {
                _storyBoard.Cards.Remove(cardTobeDeleted);
            }

            return cardTobeDeleted;
        }

        public void ChangeState(int cardId)
        {
            GetUserStory(cardId).State++;
        }

        public void ResetState(int cardId)
        {
            GetUserStory(cardId).State = 0;
        }
    }
}


        
