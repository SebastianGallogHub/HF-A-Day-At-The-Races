using System.Windows.Forms;

namespace A_Day_At_The_Races
{
    public class Guy
    {
        public string Name; // The guy's name
        private Bet MyBet; // An instance of Bet that has his bet // Supongo que es privado a Guy 
        public int Cash; // How much cash he has
                         // The last two fields are the guy’s GUI controls on the form
        public RadioButton MyRadioButton = null; // My RadioButton
        public Label MyLabel = null; // My Label

        public Guy(string Name, int Cash, RadioButton radioButton, Label label)
        {
            this.Name = Name;
            this.Cash = Cash;
            this.MyBet = new Bet(0,0,this);
            this.MyRadioButton = radioButton;
            this.MyLabel = label;
        }

        public void UpdateLabel()
        {
            // Set my label to my bet’s description, and the label on my
            // radio button to show my cash ("Joe has 43 bucks")
            MyLabel.Text = string.Format(MyBet.GetDescription());
            MyRadioButton.Text = string.Format("{0} has {1} bucks", Name, Cash);
        }

        public void ClearBet() 
        {
            this.MyBet = new Bet(0,0,this);
        } // Reset my bet so it’s zero

        public bool PlaceBet(int BetAmount, int DogToWin)
        {
            // Place a new bet and store it in my bet field
            // Return true if the guy had enough money to bet
            if (BetAmount > Cash)
                return false;
            else
                MyBet = new Bet(BetAmount, DogToWin, this);
            return true;
        }

        public void Collect(int Winner)
        {
            // Ask my bet to pay out, clear my bet, and update my labels
            this.Cash += MyBet.PayOut(Winner);
            ClearBet();
            UpdateLabel();
        }
    }
}
