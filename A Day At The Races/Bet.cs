
namespace A_Day_At_The_Races
{
    public class Bet
    {
        public int Amount; // The amount of cash that was bet
        public int Dog; // The number of the dog the bet is on
        public Guy Bettor; // The guy who placed the bet

        public Bet(int Bet, int DogTowin, Guy Bettor)
        {
            this.Amount = Bet;
            this.Dog = DogTowin;
            this.Bettor = Bettor;
        }

        public string GetDescription()
        {
            // Return a string that says who placed the bet, how much
            // cash was bet, and which dog he bet on ("Joe bets 8 on
            // dog #4"). If the amount is zero, no bet was placed
            // ("Joe hasn’t placed a bet").
            if (Amount == 0)
                return string.Format("{0} hasn´t placed a bet", Bettor.Name);
            else
                return string.Format("{0} bets {1} buck(s) on dog #{2}", Bettor.Name, Amount, Dog);
        }
        
        public int PayOut(int Winner)
        {
            // The parameter is the winner of the race. If the dog won,
            // return the amount bet. Otherwise, return the negative of
            // the amount bet.
            if (Winner == Dog)
                return Amount;
            else
                return -Amount;
        }
    }
}
