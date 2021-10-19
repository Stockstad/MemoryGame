using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MemoryGame
{
    class player1
    {

        private int playerScore;
        private int movesMade;


        public player1(int playerScore, int movesMade)
        {

            this.playerScore = playerScore;
            this.movesMade = movesMade;

        }

        public int PlayerScore
        {
            get { return playerScore; }
            set { playerScore = value; }
        }

        public int MovesMade
        {
            get { return movesMade; }
            set { movesMade = value; }
        }


    }
}
