using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MemoryGame
{
    class Player: Game
    {

        private int score { get; set; }
        private int playerNum { get; set; }
        private int movesMade { get; set; }
        public string playerName { get; set; }
        public string colour { get; set; }
        private string selectedCardOne { get; set; }
        private string selectedCardTwo { get; set; }


        public Player(int playerNum, int score, int movesMade, string playerName, string colour, string selectedCardOne, string selectedCardTwo, int numberOfPlayers) : base(numberOfPlayers)
        {
            this.playerNum = playerNum;
            this.score = score;
            this.movesMade = movesMade;
            this.playerName = playerName;
            this.colour = colour;
            this.selectedCardOne = selectedCardOne;
            this.selectedCardTwo = selectedCardTwo; 


        }

        public bool Matching()
        {
            if (selectedCardTwo == selectedCardOne)
            {
                return true;
            }
            else
            {
                return false;
            }


        }

        public int ScoreAdd()
        {
            return score++;
        }

        public int MovesAdd()
        {
            return movesMade++;
        }

        public int ContinueTurn()
        {
            if (Matching())
            {
                return playerNum;
            }
            else
            {
               if (numberOfPlayers > playerNum)
               {
                    return playerNum++;
               }
               else
               {
                    return 0;
               }


            }      

        }

     

    }
}
