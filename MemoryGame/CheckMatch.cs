using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MemoryGame
{
    class CheckMatch
    {

        private string cardOne;
        private string cardTwo;
        public int player;
        
      


        public CheckMatch(string cardOne, string cardTwo, int player)
        {
            this.cardOne = cardOne;
            this.cardTwo = cardTwo;
            this.player = player;

        }


        public string CardOne
        {                       
            get { return cardOne; }
            set { cardOne = value; }


        }

        public string CardTwo
        {
            get { return cardTwo; }
            set { cardTwo = value; }




        }

        public int Player
        {
            get { return player; }
            set { player = value; }


        }

        public bool Matching()
        {
            if (cardOne == cardTwo)
            { return true; }



            else
            { return false; }
            




        }

        
        
        
       

    }
        
    
}
