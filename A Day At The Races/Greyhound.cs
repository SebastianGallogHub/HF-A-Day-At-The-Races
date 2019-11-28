using System;
using System.Windows.Forms;

namespace A_Day_At_The_Races
{
    public class Greyhound
    {
        public int StartingPosition; // Where my PictureBox starts
        public int RacetrackLength; // How long the racetrack is
        public PictureBox MyPictureBox = null; // My PictureBox object
        public int Location = 0; // My Location on the racetrack
        private Random Randomizer; // An instance of Random // supongo que es propia del perro por lo que es privada

        public Greyhound(int startingPosition, int racetrackLength, PictureBox myPicturebox)
        {
            this.StartingPosition = startingPosition;
            this.RacetrackLength = racetrackLength;
            this.MyPictureBox = myPicturebox;
            this.Randomizer = new Random();
        }

        public bool Run()
        {
            // Move forward either 1, 2, 3 or 4 spaces at random
            // Update the position of my PictureBox on the form like this:
            // MyPictureBox.Left = StartingPosition + Location;
            // Return true if I won the race
            Location += Randomizer.Next(1, 4);
            MyPictureBox.Left = StartingPosition + Location;
            return Location >= RacetrackLength;
        }

        public void TakeStartingPosition()
        {
            // Reset my location to 0 and my PictureBox to starting position
            MyPictureBox.Left = StartingPosition;
        }
    }
}
