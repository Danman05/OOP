using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace blackjackh1
{
    struct Hand
    {
        private int cardValue;
        private int cardColor;

        public int CardValue { get => cardValue; }
        public int CardColor { get => cardColor; }

        public int DrawCards()
        {
            Random rnd = new Random();
            int cardSelector = rnd.Next(1, 12);
            return cardSelector;
        }
    }
}
