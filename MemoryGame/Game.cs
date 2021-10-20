using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MemoryGame
{
    class Game
    {

        protected int numberOfPlayers { get; set; }

        public Game(int numberOfPlayers)
        {

            this.numberOfPlayers = numberOfPlayers;

        }

        public int GetNumberOfPlayers()
        {

            return this.numberOfPlayers;

        }

    }
}
