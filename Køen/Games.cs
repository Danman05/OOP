using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Køen
{
    class Games         
    {
        private string gameTitle;
        public string GameTitle { get { return gameTitle; } }

        public Games(string gameTitle)
        {
            this.gameTitle = gameTitle;
        }
    }
}
