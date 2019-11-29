using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace A_Day_At_The_Races
{
    public partial class Parlor : Form
    {
        private Guy[] Guys;
        private Greyhound[] Dogs;
        private Guy Bettor;

        public Parlor()
        {
            InitializeComponent();
            GuysInit();
            DogsInit();
        }

        private void DogsInit()
        {
            Dogs = new Greyhound[4];
            Dogs[0] = new Greyhound(raceTrack.Left, raceTrack.Width - dog1.Width, dog1);
            Dogs[1] = new Greyhound(raceTrack.Left, raceTrack.Width - dog2.Width, dog2);
            Dogs[2] = new Greyhound(raceTrack.Left, raceTrack.Width - dog3.Width, dog3);
            Dogs[3] = new Greyhound(raceTrack.Left, raceTrack.Width - dog4.Width, dog4);
        }

        private void GuysInit()
        {
            Guys = new Guy[3];
            Guys[0] = new Guy("Joe", 50, JoeRB, Joelbl);
            Guys[1] = new Guy("Bob", 75, BobRB, Boblbl);
            Guys[2] = new Guy("Al", 45, AlRB, Allbl);
        }

        private void Parlor_Load(object sender, EventArgs e)
        {
            minimumBetLabel.Text = string.Format("Minimum Bet: ${0}", betAmount.Minimum);

            foreach (Greyhound dog in Dogs)
                dog.TakeStartingPosition();

            foreach (Guy guy in Guys)
                guy.UpdateLabel();

            JoeRB.Checked = true;
        }

        private void SelectBettor(Guy Guy)
        {
            name.Text = Guy.Name;
            Bettor = Guy;
            betAmount.Value = betAmount.Minimum;
            dogOrder.Value = dogOrder.Minimum;
        }

        private void JoeRB_CheckedChanged(object sender, EventArgs e)
        {
            SelectBettor(Guys[0]);
        }

        private void BobRB_CheckedChanged(object sender, EventArgs e)
        {
            SelectBettor(Guys[1]);
        }

        private void AlRB_CheckedChanged(object sender, EventArgs e)
        {
            SelectBettor(Guys[2]);
        }

        private void Bet_Click(object sender, EventArgs e)
        {
            Bettor.ClearBet();
            if (!Bettor.PlaceBet((int)betAmount.Value, (int)dogOrder.Value))
                MessageBox.Show(string.Format("{0} doesn't have enough bucks!", Bettor.Name), "Watch out!");
            Bettor.UpdateLabel();
        }

        private void race_Click(object sender, EventArgs e)
        {
            groupBox1.Enabled = false;
            int winner = Race();
            foreach (Guy bettor in Guys)
                bettor.Collect(winner);
            foreach (Greyhound dog in Dogs)
                dog.TakeStartingPosition();
            groupBox1.Enabled = true;
        }

        private int Race()
        {
            int winner = 0;
            while (true)
            {
                for (int i = 0; i < Dogs.Length; i++)
                    if (Dogs[i].Run())
                    {
                        winner = i + 1;
                        break;
                    }
                if (winner != 0) break;
                System.Threading.Thread.Sleep(50);
            }
            MessageBox.Show(this, string.Format("Dog #{0} won the race!", winner), "We have a winner");
            return winner;
        }
    }
}
