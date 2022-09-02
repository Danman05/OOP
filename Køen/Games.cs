using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Køen
{
    class Games         
    {   // Field
        private string gameTitle;

        // properties
        public string GameTitle { get { return gameTitle; } }

        // Constructor
        public Games(string gameTitle)
        {
            this.gameTitle = gameTitle;
        }
    }
}
