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
        public bool isMatch;
      


        public CheckMatch(string card1, string card2)
        {
            cardOne = card1;
            cardTwo = card2;


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



        
        
        
       

    }
        
    
}
