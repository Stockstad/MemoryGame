using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace MemoryGame
{
    class PlayingCards
    {

        private string filename;
        private int cardId;
        public bool isVisible = false;
        public bool unclickable = false;






        public PlayingCards(string filename, int cardId)
        {

            this.filename = filename;
            this.cardId = cardId;



        }

        public static bool matchCheck(string firstCard, string secondCard)
        {
            if (firstCard == secondCard)
            {
                return true;
            }
            else
            {
                return false;
            }





        }


        public string getFilename()
        {
            return this.filename;

        }

        public int getCardId()
        {

            return this.cardId;

        }

        public void changeUnclick()
        {
            this.unclickable = !this.unclickable;
        }


        


       





    }
}
