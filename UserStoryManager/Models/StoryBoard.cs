using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace UserStoryManager.Models
{
    public class StoryBoard
    {
        public List<TeamMember> TeamMembers { get; set; }
        public Sprint Sprint { get; set; }

        public List<Card> Cards { get; set; }

        public StoryBoard()
        {
            Cards = new List<Card>();
        }

        public void AddCard(Card card)
        {
            Cards.Add(card);
        }


    }
}
