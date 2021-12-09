using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MemoryGame
{
    class Player
    {

        private int score { get; set; }
        private int playerNum { get; set; }
        public string playerName { get; set; }
    


        public Player(int playerNum, int score, string playerName)
        {
            this.playerNum = playerNum;
            this.score = score;
            this.playerName = playerName;
          


        }

      
        public int ScoreAdd()
        {
            return score++;
        }


        public string GetAll()
        {
            return Convert.ToString(this.playerNum) + ". " + this.playerName + " SC: " + Convert.ToString(this.score);
        }



    }
}
