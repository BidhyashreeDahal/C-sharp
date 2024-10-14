using System;
using System.Collections.Generic;
using System.Linq;
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


        public static void ResetGame()
        {
            Array.Clear(board, 0, board.Length);
            Array.Clear(boatPositions, 0, boatPositions.Length);
            shortsFired = 0;
            sunkBoatsCount = 0;
            RandomizeBoats();

        }

        public static bool FireMissile(int x, int y)
        {
            if (board[x, y] != BoardStatus.Empty)
            {
                return false;
            }
            shortsFired++;
            bool isHit = checkHit(x, y);
            UpdateBoardStatus(x, y, isHit);

            if (isHit)
            {
                CheckIfBoatSunk(x, y);
            }
            return isHit;
        }

        public static bool checkHit(int x, int y) {
            return boatPositions[x, y] != Boats.NoBoat;
        }
        private static void UpdateBoardStatus(int x, int y, bool isHit)
        {
            board[x, y] = isHit ? BoardStatus.Hit : BoardStatus.Miss;
        }
        private static void CheckIfBoatSunk(int x, int y)
        {
            Boats boatHit = boatPositions[x, y];
            bool sunk = true;
            for (int i = 1; i <= MAX_BOARD_SIZE; i++)
            {
                for (int j = 1; j <= MAX_BOARD_SIZE; j++)
                {
                    if (boatPositions[i, j] == boatHit && board[i, j] != BoardStatus.Hit)
                    {
                        sunk = false;
                    }
                }
            }
            if (sunk)
            {
                sunkBoatsCount++;
            }
        }

        public static int GetShortsFired()
        {
            return shortsFired;
        }
        public static int GetSunkBoatsCount()
        {
            return sunkBoatsCount;
        }

        public static void DisplayBoard()
        {
            for(int i = 0; i < MAX_BOARD_SIZE; i++)
            {
                for(int j =0; j<MAX_BOARD_SIZE; j++)
                {
                    Console.WriteLine(board[i, j]);
                }
                Console.WriteLine();
            }
        }
    

    }
}
