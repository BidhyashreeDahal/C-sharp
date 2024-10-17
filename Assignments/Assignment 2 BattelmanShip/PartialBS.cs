using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Media;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment_2_BattelmanShip
{
    public partial class BS
    {
        // Counts for tracking shorts fired and sunk boads
        private static int shortsFired = 0;
        private static int sunkBoatsCount = 0;

        /// <summary>
        /// Resets the game board and boat positions, clears the shot count and sunk boat count, 
        /// and randomizes boat placements to start a new game.
        /// </summary>
        #region Game Management
        public static void ResetGame()
        {
            Array.Clear(board, 0, board.Length);
            Array.Clear(boatPositions, 0, boatPositions.Length);
            shortsFired = 0;
            sunkBoatsCount = 0;
            RandomizeBoats();

        }
        #endregion
        #region Game Logic
        /// <summary>
        /// Fires a missile at the specified coordinates (x, y) on the board. 
        /// Tracks the shot, checks if it's a hit or miss, and updates the board accordingly.
        /// If a hit is detected, checks if the boat is fully sunk.
        /// </summary>
        /// <param name="x">X-coordinate of the target location</param>
        /// <param name="y">Y-coordinate of the target location</param>
        /// <returns>True if a hit occurs, false if a miss</returns>
        public static bool FireMissile(int x, int y)
        {
            //Took Help From The Internet
            using (MemoryStream stream = new MemoryStream(Properties.Resources.DW))
            {
                using (SoundPlayer soundPlayer = new SoundPlayer(stream))
                {
                    soundPlayer.Play();
                }
            }

            // Increase number of shots fired  
            shortsFired++;

            // Check if a hit occurred  
            bool isHit = checkHit(x, y);

            // Update the board status  
            if (isHit)
            {
                board[x, y] = BoardStatus.Hit; // Mark as hit  
                CheckIfBoatSunk(x, y); // Check if the boat is sunk  
            }
            else
            {
                board[x, y] = BoardStatus.Miss; // Mark as miss  
            }
            return isHit; // Return whether it was a hit or miss  
        }
        /// <summary>
        /// Checks if there is a boat at the given coordinates (x, y).
        /// </summary>
        /// <param name="x">X-coordinate of the target location</param>
        /// <param name="y">Y-coordinate of the target location</param>
        /// <returns>True if a boat is at the location, false otherwise</returns>
        public static bool checkHit(int x, int y) {
            return boatPositions[x, y] != Boats.NoBoat;
        }
        /// <summary>
        /// Checks if the boat that was hit at coordinates (x, y) has been fully sunk by verifying 
        /// that all parts of the boat have been hit on the board.
        /// </summary>
        /// <param name="x">X-coordinate of the hit location</param>
        /// <param name="y">Y-coordinate of the hit location</param>
        private static void CheckIfBoatSunk(int x, int y)
        {
            Boats boatHit = boatPositions[x, y];
            bool sunk = true;
            for (int i = 0; i < MAX_BOARD_SIZE; i++)
            {
                for (int j = 0; j < MAX_BOARD_SIZE; j++)
                {
                    if (boatPositions[i, j] == boatHit && board[i, j] != BoardStatus.Hit)
                    {
                        sunk = false;
                        break;
                    }
                }
            }
            if (sunk)
            {
                sunkBoatsCount++;
                if(sunkBoatsCount ==5)
                {
                    MessageBox.Show("Congratulations All the boats are Sunken.");
                }
            }
        }
        #endregion
        #region Game Status
        /// <summary>
        /// eturns the total number of shots fired so far.
        /// </summary>
        /// <returns>The number of shorts fired</returns>

        public static int GetShortsFired()
        {
            return shortsFired;
        }
        /// <summary>
        /// Returns the total number of boats that have been sunk so far.
        /// </summary>
        /// <returns>Returns the number of boat sunks</returns>
        public static int GetSunkBoatsCount()
        {
            return sunkBoatsCount;
        }
        #endregion

    }
}
