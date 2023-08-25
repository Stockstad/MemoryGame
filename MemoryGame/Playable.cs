using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Drawing;

namespace MemoryGame
{
    class Playable
    {
        public string name { get; set; }
        public Image image { get; set; }
        public Image blur { get; set; }
        public bool taken = false;

        public Playable(string n, Image i, Image b)
        {
            name = n;
            image = i;
            blur = b;
        }

    }
}
