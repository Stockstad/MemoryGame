using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace MemoryGame
{
    class Player
    {
        public static int totalScore = 0;
        public int score = 0;
        public int movesMade = 0;
        public Playable playable;
        public Player(Playable p)
        {
            playable = p;
        }
        public int ScoreAdd()
        {
            totalScore++;
            return score++;
        }
        public string GetAll()
        {
            return Convert.ToString(this.score);
        }
        public static bool HasFinished()
        {
            if (totalScore == Game.cardPick) //change to playingCards.Count /2  later!
            {
                return true;
            }
            else
                return false;
        }
    }
}
