﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace A_Day_At_The_Races
{
    class Guy
    {
        public Bet MyBet; // An instance of Bet that has his bet
        public int Cash; // How much cash he has
                         // The last two fields are the guy’s GUI controls on the form
        public RadioButton MyRadioButton; // My RadioButton
        public Label MyLabel; // My Label

        public void UpdateLabel()
        {
            // Set my label to my bet’s description, and the label on my
            // radio button to show my cash ("Joe has 43 bucks")
        }

        public void ClearBet() { } // Reset my bet so it’s zero

        public bool PlaceBet(int BetAmount, int DogToWin)
        {
            // Place a new bet and store it in my bet field
            // Return true if the guy had enough money to bet
            return false;
        }

        public void Collect(int Winner)
        {
            // Ask my bet to pay out, clear my bet, and update my labels
        }
    }
}
